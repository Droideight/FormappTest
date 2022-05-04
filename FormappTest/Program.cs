using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormappTest
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            int ED = 3;
            string RaceName = "United States Presidential Election 2024";
            double[] PVI = { 15, -15, 0 };
            double[] Can1Quality = { 70, 70, 70 };
            double[] Can2Quality = { 70, 70, 70 };
            double[] Can1Investment = { 70, 70, 70 };
            double[] Can2Investment = { 70, 70, 70 };
            double[] Can1Enthusiasm = { 70, 70, 70 };
            double[] Can2Enthusiasm = { 70, 70, 70 };
            double[] BatchQuantity = { 50, 90, 70 };
            double[] BatchSpeed = { 90, 50, 70 };
            double[] Population = { 350000, 350000, 350000 };
            double[] MOE = { 3, 3, 3 };
        }
        static void ClearVar()
        {

        }
    }
}
