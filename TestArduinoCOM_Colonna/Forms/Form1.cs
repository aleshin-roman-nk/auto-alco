using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TestArduinoCOM.BL;
using TestArduinoCOM.BL.Db;

namespace TestArduinoCOM
{
	public partial class Form1 : Form
    {
        SessionRepository repo = new SessionRepository(new ContextFactory());
        Session _session = null;
        BindingSource bs = new BindingSource();

        IGPointEditView gPointEditView = new GPointEditDlg();

        Queue<GPoint> _buffer = new Queue<GPoint>();

        List<Image> _processAnimation = new List<Image> { Properties.Resources.pr001, 
            Properties.Resources.pr002, 
            Properties.Resources.pr003,
            Properties.Resources.pr004,
            Properties.Resources.pr005,
            Properties.Resources.pr006,
            Properties.Resources.pr007,
            Properties.Resources.pr008,
            Properties.Resources.pr009,
            Properties.Resources.pr010
        };
        int _framewIndex = 0;
        int help_to_stop_animation = 0;
        const int max_awaiting_ = 15; //тиков по 100 мс


        int lastCount = 10;
        decimal max_temp;
        klapan_state klapan = klapan_state.close;

        private void set_klapan_state(klapan_state st)
		{
            klapan = st;

            if (klapan == klapan_state.close)
			{
                pictureBox2.Image = Properties.Resources.klapan_off;
                //btnOpenCloseKlapan.BackgroundImage = Properties.Resources.kl_toggle_off;
            }
            else if(klapan == klapan_state.open)
			{
                pictureBox2.Image = Properties.Resources.klapan_on;
                //btnOpenCloseKlapan.BackgroundImage = Properties.Resources.kl_toggle_on;
            }
        }

        private void set_klapan_toggle_btn_state(bool auto_mode, klapan_state st)
		{
			if (auto_mode)
			{
                btnOpenCloseKlapan.BackgroundImage = Properties.Resources.kl_toggle_disabled;
                btnOpenCloseKlapan.Enabled = false;
                return;
			}
			else
			{
                btnOpenCloseKlapan.Enabled = true;
            }

            if(st == klapan_state.close)
			{
                btnOpenCloseKlapan.BackgroundImage = Properties.Resources.kl_toggle_off;
            }
			else
			{
                btnOpenCloseKlapan.BackgroundImage = Properties.Resources.kl_toggle_on;
            }
		}

        private void set_auto_mode_state(bool st)
		{
			if (st)
			{
                btnAutoMode.BackgroundImage = Properties.Resources.automatic_mode;
            }
			else
			{
                btnAutoMode.BackgroundImage = Properties.Resources.manual_mode;
            }
		}

        /*
         * Вспомогательный таймер запускается на 1,5 сек, и при обновлении сбрасывается.
         * Если не сбросился, до досчитав до 1,5 сек выключить анимацию.
         * 
         * 
         */

        public Form1()
        {
            InitializeComponent();

            txtLastNumberPoints.Text = lastCount.ToString();

            dataGridView1.DataSource = bs;

            chart1.Titles.Add($"Temperatures");

            max_temp = numericUpDownUpperTemp.Value;
            numericUpDownUpperTemp.BackColor = Color.Green;

            updateCOMS();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.DataSource = new string[] { "com1", "com2" };//COM_ARDUINO.GetAllCOM();
            repo.Init();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
			try
			{
                COM_ARDUINO.stop();
            }
			catch (Exception ex)
			{
                MessageBox.Show(ex.Message);
            }
        }

        private void Update(string str)
		{
            this.changeCtrlAsync(()=> {
				//Text = str;
				// Проблема возникает, когда приложение запускается в момент получения ломанных данных.
				// Для этого и начинать пакет надо с тега <begin>
				// И если достигли <end>, а в начале собранной строки нету <begin>, сбрасываем этот пакет.

				//pictureBoxProcessing.Image = _processAnimation[_framewIndex];
				//_framewIndex++;
				//if (_framewIndex >= _processAnimation.Count) _framewIndex = 0;

				if (!timer2Awaiter.Enabled)
				{
                    timer2Awaiter.Enabled = true;
                    timer2Awaiter.Start();
                    timer1.Enabled = true;
                    timer1.Enabled = true;
				}
                help_to_stop_animation = 0;

                LogGer.WriteLine(str);

                var data = ReceivedData.Deserialize(str);
                if(data == null)
				{
                    Text = "!!!Invalid data!!!";
                    return;
				}
                Text = Newtonsoft.Json.JsonConvert.SerializeObject(data);

                isAuto = data.auto;

                set_klapan_state(data.kl);
                set_auto_mode_state(data.auto);
                set_klapan_toggle_btn_state(data.auto, data.kl);
                txtTempUO.Text = data.T_uo.ToString("#.#");
                txtTempCUB.Text = data.T_cub.ToString("#.#");
                lblMaxTempInController.Text = data.maximum_temperature_acually.ToString("#.#");
                lblMinTempInController.Text = data.min_temperature_acually.ToString("#.#");
                lblKlapanOpenDuration.Text = $"{data.open_duration / 60} мин";

                AddPoint(DateTime.Now, data.T_uo, data.T_cub, "");

                if (_session != null)
                {
                    drawChart(_session.LastPoints(lastCount, DateTime.Now));
                }

                if(data.error_code > 0)
				{
                    MessageBox.Show("Error in MC");
				}
            });
        }

		private void btnOpenSession_Click(object sender, EventArgs e)
		{
            ChooseSessionForm chooseSessionForm = new ChooseSessionForm();

            var res = chooseSessionForm.Go(repo.GetAll());

            if (res == null) return;// ответ какой попало, поэтому если передумал выбирать, всеравно вырубает текущую сесию.

            //_session = res;
            _session = repo.Load(res.Id);

            if (_session == null) label2.Text = "-";
            else
			{
                label2.Text = _session.Name;
                bs.DataSource = null;
                //bs.DataSource = _session.GPoints.OrderByDescending(x => x.Id);
                bs.DataSource = _session.Points;

                if (_session != null)
                {
                    drawChart(_session.LastPoints(lastCount, DateTime.Now));
                }
            }
        }

        private void drawChart( IEnumerable<GPoint> gra)
		{
            chart1.Series.Clear();
            //chart1.Titles.Clear();

            // Resolves a problem of displaying charts of other collection when we can not see a chart.
            chart1.ChartAreas[0].RecalculateAxesScale();

            // Set palette
            //this.chart1.Palette = ChartColorPalette.Berry;

            // Set title
            //chart1.Titles.Add($"{title}; Total time: {TimeSpan.FromSeconds(points.Sum(x => x.Seconds)).ToString(@"hh\:mm")}");

            //_CurrentDataPoint.OriginalColor = chart1.PaletteCustomColors[0];

            Series seriesT_uo = this.chart1.Series.Add("T узел отбора");
            seriesT_uo.ChartType = SeriesChartType.Line;
            seriesT_uo.BorderWidth = 2;

            // alco
            Series seriesT_cub = this.chart1.Series.Add("Т куб");
            seriesT_cub.ChartType = SeriesChartType.Line;
            seriesT_cub.BorderWidth = 2;
            //

            chart1.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;

            // Add series.
            foreach (var item in gra)
            {
                seriesT_uo.Points.AddXY(item.TimePoint.ToString("HH:mm"), item.TempUO);
                seriesT_cub.Points.AddXY(item.TimePoint.ToString("HH:mm"), item.TempCUB);
            }
        }

		private void btnCreateSession_Click(object sender, EventArgs e)
		{
            if (string.IsNullOrEmpty(txtGetSessionName.Text)) return;

            _session = repo.Create(txtGetSessionName.Text);

            bs.DataSource = null;
            bs.DataSource = _session.Points;
            label2.Text = _session.Name;
        }

        bool update_grid = true;

        private void AddPoint(DateTime t, decimal t_uo, decimal t_cub, string comm)
		{
            if (_session == null) return;

            var p = new GPoint { TempCUB = t_cub, TempUO = t_uo, Comment = comm, TimePoint = t };

            p.SessionId = _session.Id;

            _session.GPoints.Add(p);

            _buffer.Enqueue(p);

            if(_buffer.Count >= 10)
			{
                txtPointsLoaded.Text = _session.GPoints.Count.ToString();
                //repo.SaveGPoint(p);
                repo.SaveGPointRange(_buffer.ToList());
                _buffer.Clear();
                if (update_grid)
                    bs.DataSource = _session.Points;
			}
        }

		private void btnSetNumberOflastpoints_Click(object sender, EventArgs e)
		{
			try
			{
                int res;

                if(int.TryParse(txtLastNumberPoints.Text, out res))
				{
                    lastCount = res;
                    if (_session != null)
                    {
                        var i = _session.LastPoints(lastCount, DateTime.Now);
                        drawChart(i);
                    }
                }
			}
			catch (Exception)
			{

			};
		}

		private void btnSetMinMax_Click(object sender, EventArgs e)
		{
            chart1.ChartAreas[0].AxisY.Minimum = double.Parse(txtMin.Text.Replace('.', ','));
            chart1.ChartAreas[0].AxisY.Maximum = double.Parse(txtMax.Text.Replace('.', ','));
        }

		private void btnSetMaxTemper_Click(object sender, EventArgs e)
		{
            numericUpDownUpperTemp.BackColor = Color.Green;
            numericUpDownLowTemp.BackColor = Color.Green;

            COM_ARDUINO.SetMaxTemperatureUO(numericUpDownLowTemp.Value, numericUpDownUpperTemp.Value);
        }

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
            numericUpDownUpperTemp.BackColor = Color.Red;
        }

		private void btnGoCOM_Click(object sender, EventArgs e)
		{
            try
            {
                var com = comboBox1.Text;
                COM_ARDUINO.start(com, Update);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

		private void btnStopCOM_Click(object sender, EventArgs e)
		{
            try
            {
                COM_ARDUINO.stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        BindingSource bsCOMS = new BindingSource();

        void updateCOMS()
		{
            var r = COM_ARDUINO.GetAllCOM();

            bsCOMS.DataSource = r;

            comboBox1.DataSource = bsCOMS;
		}

		private void btnUpdCOMLIST_Click(object sender, EventArgs e)
		{
            updateCOMS();
        }

        GPoint _current => bs.Current as GPoint;

		private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
		{
            if(Keys.Enter == e.KeyCode)
			{
                var cur = _current;

                if (cur == null) return;

                update_grid = false;
                if (gPointEditView.Dispaly(cur.Alco, cur.Comment))
				{
                    cur.Alco = gPointEditView.res_alco;
                    cur.Comment = gPointEditView.res_comment;
                    repo.SaveGPoint(cur);
                }
                update_grid = true; ;

                e.Handled = true;
			}
		}

		private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
		{
   //         var ctrl = sender as NumericUpDown;

   //         if (e.KeyCode == Keys.Enter)
			//{
   //             ctrl.BackColor = Color.Green;

   //             COM_ARDUINO.SetMaxTemperatureUO(ctrl.Value);

   //             e.Handled = true;
			//}
        }

		private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
		{
            var ctrl = sender as NumericUpDown;

            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
            {
                e.KeyChar = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }

            if (e.KeyChar == 13)
			{
                ctrl.BackColor = Color.Green;
            }
            else ctrl.BackColor = Color.Red;
        }
        bool isAuto = false;
		private void btnAutoMode_Click(object sender, EventArgs e)
		{
            COM_ARDUINO.SetAutoMode(!isAuto);
        }

		private void btnOpenCloseKlapan_Click(object sender, EventArgs e)
		{
            if (klapan == klapan_state.close)
                COM_ARDUINO.OpenKlapan();
            else
                COM_ARDUINO.CloseKlapan();
		}

		private void label3_Click(object sender, EventArgs e)
		{
            textBox1.Visible = true;
            textBox1.Focus();
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
            if(e.KeyCode == Keys.Escape)
			{
                (sender as TextBox).Visible = false;
                e.Handled = true;
			}
            else if (e.KeyCode == Keys.Enter)
			{
                var txt = sender as TextBox;
                txt.Visible = false;
                e.Handled = true;

                int dur_sec = int.Parse(txt.Text) * 60;

                COM_ARDUINO.SetDuration(dur_sec);
            }
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
            (sender as TextBox).Visible = false;
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
            pictureBoxProcessing.Image = _processAnimation[_framewIndex];
            _framewIndex++;
            if (_framewIndex >= _processAnimation.Count) _framewIndex = 0;
        }

		private void timer2Awaiter_Tick(object sender, EventArgs e)
		{
            help_to_stop_animation++;
            if (help_to_stop_animation >= max_awaiting_)
			{
                timer1.Enabled = false;
                timer1.Stop();
                timer2Awaiter.Stop();
                timer2Awaiter.Enabled = false;
			}
        }
	}
}
