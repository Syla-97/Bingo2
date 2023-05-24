using System;

namespace Bingo2
{
    public partial class root : Form
    {
        /// <summary>
        /// Global
        /// </summary>
        internal static class Global
        {
            internal static List<int> Numbers = new List<int>(Enumerable.Range(1, 75));                                                         // 選対象の数字の配列
            internal static int cnt = Numbers.Count;                                                                                            // Numbersのリストの要素数(LengthはArray用)
            internal static int[] num_previous = new int[5] { 0, 0, 0, 0, 0 };                                                                  // 履歴を出すための配列
            internal static int select = 0;                                                                                                     // 選んだ番号
            internal const int fastSelectTimes = 39;                                                                                            // 早く選んでる風の時の繰り返し回数
            internal const int fastSelectTime = 50;                                                                                             // 早く選んでる風の時の間隔(ミリ秒単位)
            internal const int slowSelectTimes = 5;                                                                                             // 遅く選んでる風の時の繰り返し回数
            internal const int slowSelectTime = 250;                                                                                            // 遅く選んでる風の時の間隔(ミリ秒単位)
            internal const int finalSelectTime = 500;                                                                                           // 数字が決定するまでの時の間隔(ミリ秒単位)
            internal const int colorChangeTime = 500;                                                                                           // 決定後の背景色が変わる時の間隔(ミリ秒単位)
            internal const int colorChangeTimes = 3;                                                                                            // 決定後のエフェクトの繰り返し回数
            internal readonly static List<string> rgb = new List<string> { "#E55381", "#5DA9E9", "#F4D53E", "#17B890", "#FFFFFF" };             // B, I, N, G, O 列の色(HTMLカラーコード)
            internal readonly static List<string> brgyCode = new List<string> { "#000000", "#FF0000", "#00FF00", "#FFFF00" };                   // Black, Red, Green, Yellow(HTMLカラーコード)
            internal static bool rollExists = false;                                                                                            // ロール音のファイルのフラグ
            internal readonly static string rollFilepath = Program.Global.exeDirPath + "\\drumroll.wav";                                        // ロール音のファイルパス
            internal static bool hitExists = false;                                                                                             // ヒット音のファイルのフラグ
            internal readonly static string hitFilepath = Program.Global.exeDirPath + "\\drumhit.wav";                                          // ヒット音のファイルパス
            internal static List<string> msg = new List<string> { "Initialize", "S T A R T !", "N E X T >>", " H I S T O R Y", "E R R O R" };   // 表示テキスト一覧
        }

        private System.Media.SoundPlayer drumRoll, drumHit;                                                                                     // SoundPlayerオブジェクトの使用


        private void colorChanger(int target)
        {
            switch (target)
            {
                case 0:
                    break;
                case 1:
                    num_1.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_1.ForeColor = ColorTranslator.FromHtml(Global.rgb[0]);
                    break;
                case 2:
                    num_2.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_2.ForeColor = ColorTranslator.FromHtml(Global.rgb[0]);
                    break;
                case 3:
                    num_3.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_3.ForeColor = ColorTranslator.FromHtml(Global.rgb[0]);
                    break;
                case 4:
                    num_4.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_4.ForeColor = ColorTranslator.FromHtml(Global.rgb[0]);
                    break;
                case 5:
                    num_5.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_5.ForeColor = ColorTranslator.FromHtml(Global.rgb[0]);
                    break;
                case 6:
                    num_6.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_6.ForeColor = ColorTranslator.FromHtml(Global.rgb[0]);
                    break;
                case 7:
                    num_7.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_7.ForeColor = ColorTranslator.FromHtml(Global.rgb[0]);
                    break;
                case 8:
                    num_8.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_8.ForeColor = ColorTranslator.FromHtml(Global.rgb[0]);
                    break;
                case 9:
                    num_9.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_9.ForeColor = ColorTranslator.FromHtml(Global.rgb[0]);
                    break;
                case 10:
                    num_10.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_10.ForeColor = ColorTranslator.FromHtml(Global.rgb[0]);
                    break;
                case 11:
                    num_11.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_11.ForeColor = ColorTranslator.FromHtml(Global.rgb[0]);
                    break;
                case 12:
                    num_12.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_12.ForeColor = ColorTranslator.FromHtml(Global.rgb[0]);
                    break;
                case 13:
                    num_13.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_13.ForeColor = ColorTranslator.FromHtml(Global.rgb[0]);
                    break;
                case 14:
                    num_14.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_14.ForeColor = ColorTranslator.FromHtml(Global.rgb[0]);
                    break;
                case 15:
                    num_15.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_15.ForeColor = ColorTranslator.FromHtml(Global.rgb[0]);
                    break;
                case 16:
                    num_16.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_16.ForeColor = ColorTranslator.FromHtml(Global.rgb[1]);
                    break;
                case 17:
                    num_17.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_17.ForeColor = ColorTranslator.FromHtml(Global.rgb[1]);
                    break;
                case 18:
                    num_18.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_18.ForeColor = ColorTranslator.FromHtml(Global.rgb[1]);
                    break;
                case 19:
                    num_19.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_19.ForeColor = ColorTranslator.FromHtml(Global.rgb[1]);
                    break;
                case 20:
                    num_20.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_20.ForeColor = ColorTranslator.FromHtml(Global.rgb[1]);
                    break;
                case 21:
                    num_21.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_21.ForeColor = ColorTranslator.FromHtml(Global.rgb[1]);
                    break;
                case 22:
                    num_22.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_22.ForeColor = ColorTranslator.FromHtml(Global.rgb[1]);
                    break;
                case 23:
                    num_23.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_23.ForeColor = ColorTranslator.FromHtml(Global.rgb[1]);
                    break;
                case 24:
                    num_24.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_24.ForeColor = ColorTranslator.FromHtml(Global.rgb[1]);
                    break;
                case 25:
                    num_25.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_25.ForeColor = ColorTranslator.FromHtml(Global.rgb[1]);
                    break;
                case 26:
                    num_26.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_26.ForeColor = ColorTranslator.FromHtml(Global.rgb[1]);
                    break;
                case 27:
                    num_27.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_27.ForeColor = ColorTranslator.FromHtml(Global.rgb[1]);
                    break;
                case 28:
                    num_28.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_28.ForeColor = ColorTranslator.FromHtml(Global.rgb[1]);
                    break;
                case 29:
                    num_29.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_29.ForeColor = ColorTranslator.FromHtml(Global.rgb[1]);
                    break;
                case 30:
                    num_30.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_30.ForeColor = ColorTranslator.FromHtml(Global.rgb[1]);
                    break;
                case 31:
                    num_31.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_31.ForeColor = ColorTranslator.FromHtml(Global.rgb[2]);
                    break;
                case 32:
                    num_32.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_32.ForeColor = ColorTranslator.FromHtml(Global.rgb[2]);
                    break;
                case 33:
                    num_33.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_33.ForeColor = ColorTranslator.FromHtml(Global.rgb[2]);
                    break;
                case 34:
                    num_34.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_34.ForeColor = ColorTranslator.FromHtml(Global.rgb[2]);
                    break;
                case 35:
                    num_35.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_35.ForeColor = ColorTranslator.FromHtml(Global.rgb[2]);
                    break;
                case 36:
                    num_36.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_36.ForeColor = ColorTranslator.FromHtml(Global.rgb[2]);
                    break;
                case 37:
                    num_37.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_37.ForeColor = ColorTranslator.FromHtml(Global.rgb[2]);
                    break;
                case 38:
                    num_38.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_38.ForeColor = ColorTranslator.FromHtml(Global.rgb[2]);
                    break;
                case 39:
                    num_39.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_39.ForeColor = ColorTranslator.FromHtml(Global.rgb[2]);
                    break;
                case 40:
                    num_40.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_40.ForeColor = ColorTranslator.FromHtml(Global.rgb[2]);
                    break;
                case 41:
                    num_41.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_41.ForeColor = ColorTranslator.FromHtml(Global.rgb[2]);
                    break;
                case 42:
                    num_42.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_42.ForeColor = ColorTranslator.FromHtml(Global.rgb[2]);
                    break;
                case 43:
                    num_43.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_43.ForeColor = ColorTranslator.FromHtml(Global.rgb[2]);
                    break;
                case 44:
                    num_44.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_44.ForeColor = ColorTranslator.FromHtml(Global.rgb[2]);
                    break;
                case 45:
                    num_45.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_45.ForeColor = ColorTranslator.FromHtml(Global.rgb[2]);
                    break;
                case 46:
                    num_46.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_46.ForeColor = ColorTranslator.FromHtml(Global.rgb[3]);
                    break;
                case 47:
                    num_47.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_47.ForeColor = ColorTranslator.FromHtml(Global.rgb[3]);
                    break;
                case 48:
                    num_48.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_48.ForeColor = ColorTranslator.FromHtml(Global.rgb[3]);
                    break;
                case 49:
                    num_49.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_49.ForeColor = ColorTranslator.FromHtml(Global.rgb[3]);
                    break;
                case 50:
                    num_50.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_50.ForeColor = ColorTranslator.FromHtml(Global.rgb[3]);
                    break;
                case 51:
                    num_51.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_51.ForeColor = ColorTranslator.FromHtml(Global.rgb[3]);
                    break;
                case 52:
                    num_52.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_52.ForeColor = ColorTranslator.FromHtml(Global.rgb[3]);
                    break;
                case 53:
                    num_53.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_53.ForeColor = ColorTranslator.FromHtml(Global.rgb[3]);
                    break;
                case 54:
                    num_54.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_54.ForeColor = ColorTranslator.FromHtml(Global.rgb[3]);
                    break;
                case 55:
                    num_55.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_55.ForeColor = ColorTranslator.FromHtml(Global.rgb[3]);
                    break;
                case 56:
                    num_56.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_56.ForeColor = ColorTranslator.FromHtml(Global.rgb[3]);
                    break;
                case 57:
                    num_57.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_57.ForeColor = ColorTranslator.FromHtml(Global.rgb[3]);
                    break;
                case 58:
                    num_58.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_58.ForeColor = ColorTranslator.FromHtml(Global.rgb[3]);
                    break;
                case 59:
                    num_59.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_59.ForeColor = ColorTranslator.FromHtml(Global.rgb[3]);
                    break;
                case 60:
                    num_60.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_60.ForeColor = ColorTranslator.FromHtml(Global.rgb[3]);
                    break;
                case 61:
                    num_61.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_61.ForeColor = ColorTranslator.FromHtml(Global.rgb[4]);
                    break;
                case 62:
                    num_62.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_62.ForeColor = ColorTranslator.FromHtml(Global.rgb[4]);
                    break;
                case 63:
                    num_63.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_63.ForeColor = ColorTranslator.FromHtml(Global.rgb[4]);
                    break;
                case 64:
                    num_64.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_64.ForeColor = ColorTranslator.FromHtml(Global.rgb[4]);
                    break;
                case 65:
                    num_65.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_65.ForeColor = ColorTranslator.FromHtml(Global.rgb[4]);
                    break;
                case 66:
                    num_66.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_66.ForeColor = ColorTranslator.FromHtml(Global.rgb[4]);
                    break;
                case 67:
                    num_67.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_67.ForeColor = ColorTranslator.FromHtml(Global.rgb[4]);
                    break;
                case 68:
                    num_68.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_68.ForeColor = ColorTranslator.FromHtml(Global.rgb[4]);
                    break;
                case 69:
                    num_69.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_69.ForeColor = ColorTranslator.FromHtml(Global.rgb[4]);
                    break;
                case 70:
                    num_70.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_70.ForeColor = ColorTranslator.FromHtml(Global.rgb[4]);
                    break;
                case 71:
                    num_71.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_71.ForeColor = ColorTranslator.FromHtml(Global.rgb[4]);
                    break;
                case 72:
                    num_72.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_72.ForeColor = ColorTranslator.FromHtml(Global.rgb[4]);
                    break;
                case 73:
                    num_73.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_73.ForeColor = ColorTranslator.FromHtml(Global.rgb[4]);
                    break;
                case 74:
                    num_74.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_74.ForeColor = ColorTranslator.FromHtml(Global.rgb[4]);
                    break;
                case 75:
                    num_75.BackColor = ColorTranslator.FromHtml(Global.brgyCode[0]);
                    num_75.ForeColor = ColorTranslator.FromHtml(Global.rgb[4]);
                    break;
                default:
                    prev1.Text = "E";
                    prev2.Text = "R";
                    prev3.Text = "R";
                    prev4.Text = "O";
                    prev5.Text = "R";
                    break;
            }
        }


        /// <summary>
        /// Bingo Number Select Effect
        /// </summary>
        private async void selectEffect()
        {
            int sel;
            int[] array = Global.Numbers.OrderBy(i => Guid.NewGuid()).ToArray();                                                                // Global.Numbers配列をランダムに入れ替える
            Random random = new Random();                                                                                                       // 乱数生成の準備

            for (int i = 0; i < Global.fastSelectTimes; i++)                                                                                    // 早く選んでいる風の処理
            {
                int rand = random.Next(0, Global.cnt);
                num.Text = array[rand].ToString();                                                                                              // 数字表示
                await Task.Delay(Global.fastSelectTime);                                                                                        // 待機処理
            }

            for (int i = 0; i < Global.slowSelectTimes; i++)                                                                                    // 遅く選んでいる風の処理
            {
                int rand = random.Next(0, Global.cnt);
                num.Text = array[rand].ToString();
                await Task.Delay(Global.slowSelectTime);
            }

            sel = array[random.Next(0, Global.cnt)];                                                                                            // 番号の決定
            await Task.Delay(Global.finalSelectTime);

            if (Global.rollExists == true)
            {
                drumRoll.Stop();                                                                                                                // ドラムロールの停止
            }

            if (Global.hitExists == true)
            {
                drumHit.Play();                                                                                                                 // ドラムを叩く音声の再生
            }

            num.Text = sel.ToString();                                                                                                          // 決定した番号を表示


            for (int i = 0; i < Global.colorChangeTimes; i++)                                                                                   // 決定したことをアナウンス
            {
                num.BackColor = ColorTranslator.FromHtml(Global.brgyCode[1]);
                await Task.Delay(Global.colorChangeTime);
                num.BackColor = ColorTranslator.FromHtml(Global.brgyCode[2]);
                await Task.Delay(Global.colorChangeTime);
                num.BackColor = ColorTranslator.FromHtml(Global.brgyCode[3]);
                await Task.Delay(Global.colorChangeTime);
            }

            colorChanger(sel);                                                                                                                  // 対応する番号のセルの色を変更

            if (Global.hitExists == true)
            {
                drumHit.Stop();                                                                                                                 // ドラムを叩く音声の停止
            }

            num.BackColor = SystemColors.Control;                                                                                               // アナウンス終了(背景色を初期値へ)

            Global.select = sel;                                                                                                                // Globalへ値をコピー
            Global.Numbers.Remove(sel);                                                                                                         // 選んだ番号に対応する要素を削除
            Global.cnt--;                                                                                                                       // リストの長さを短くする

            for (int i = 4; i > 0; i--)
                Global.num_previous[i] = Global.num_previous[i - 1];                                                                            // 履歴の更新処理

            btn.Enabled = true;                                                                                                                 // Nextボタンを有効化
        }


        /// <summary>
        /// When sub form closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsClosed(object sender, EventArgs e)                                                                                 // サブフォーム終了時
        {
            btn.Enabled = true;
            btn.Text = Global.msg[1]; 
        }

        /// <summary>
        /// Event >> button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            btn.Enabled = false;
            if (btn.Text == Global.msg[0])
            {
                sub settings = new sub();
                settings.Left = Left + (Width - settings.Width) / 2;
                settings.Top = Top + (Height - settings.Height) / 2;
                settings.Closed += new EventHandler(settingsClosed);
                settings.Show();

                return;
            }
            else if (btn.Text == Global.msg[1])
            {
                Global.rollExists = File.Exists(Global.rollFilepath);
                Global.hitExists = File.Exists(Global.hitFilepath);

                if (Global.rollExists == true)
                {
                    drumRoll = new System.Media.SoundPlayer(Global.rollFilepath);
                }
                if (Global.hitExists == true)
                {
                    drumHit = new System.Media.SoundPlayer(Global.hitFilepath);
                }

                history.Text = Global.msg[3];

                btn.Text = Global.msg[2];
            }
            else if (btn.Text == Global.msg[2])
            {
                Global.num_previous[0] = Global.select;
                prev1.Text = Global.num_previous[0].ToString();
                if (Global.cnt < 74)
                {
                    prev2.Text = Global.num_previous[1].ToString();
                }
                if (Global.cnt < 73)
                {
                    prev3.Text = Global.num_previous[2].ToString();
                }
                if (Global.cnt < 72)
                {
                    prev4.Text = Global.num_previous[3].ToString();
                }
                if (Global.cnt < 71)
                {
                    prev5.Text = Global.num_previous[4].ToString();
                }
            }
            else if (Global.cnt == 75)
            {
                MessageBox.Show("すべての番号が出揃いました。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Environment.Exit(0);
            }
            else
            {
                btn.Text = Global.msg[4];
                MessageBox.Show("ERROR >> Please check Source Code...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
            if (Global.rollExists == true)
            {
                drumRoll.Play();
            }
            selectEffect();
        }


        /// <summary>
        ///  ウィンドウの表示
        /// </summary>
        public root()
        {
            InitializeComponent();                                                                                                              // デザイナーで作成したデザインを表示
            setBackColor();                                                                                                                     // BINGOの背景色を設定
        }
    }
}