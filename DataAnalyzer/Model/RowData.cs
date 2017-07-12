using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalyzer.Model
{
    public class RowData
    {
        public RowData(string vin, string datetime, double L01_JF_T, double L01_JF_L, double L01_JF_H, double L02_JF_T, double L02_JF_L, double L02_JF_H, double L03_JF_T, double L03_JF_L, double L03_JF_H, double L04_JF_T, double L04_JF_L, double L04_JF_H, double L05_JF_T, double L05_JF_L, double L05_JF_H, double L06_JF_T, double L06_JF_L, double L06_JF_H, double L07_JF_T, double L07_JF_L, double L07_JF_H, double L21_JF_T, double L21_JF_L, double L21_JF_H, double L22_JF_T, double L22_JF_L, double L22_JF_H, double L23_JF_T, double L23_JF_L, double L23_JF_H, double L24_JF_T, double L24_JF_L, double L24_JF_H, double L25_JF_T, double L25_JF_L, double L25_JF_H, double L26_JF_T, double L26_JF_L, double L26_JF_H, double L27_JF_T, double L27_JF_L, double L27_JF_H, double L28_JF_T, double L28_JF_L, double L28_JF_H, double L29_JF_T, double L29_JF_L, double L29_JF_H, double L30_JF_T, double L30_JF_L, double L30_JF_H, double R01_JF_T, double R01_JF_L, double R01_JF_H, double R02_JF_T, double R02_JF_L, double R02_JF_H, double R03_JF_T, double R03_JF_L, double R03_JF_H, double R04_JF_T, double R04_JF_L, double R04_JF_H, double R05_JF_T, double R05_JF_L, double R05_JF_H, double R06_JF_T, double R06_JF_L, double R06_JF_H, double R07_JF_T, double R07_JF_L, double R07_JF_H, double R21_JF_T, double R21_JF_L, double R21_JF_H, double R22_JF_T, double R22_JF_L, double R22_JF_H, double R23_JF_T, double R23_JF_L, double R23_JF_H, double R24_JF_T, double R24_JF_L, double R24_JF_H, double R25_JF_T, double R25_JF_L, double R25_JF_H, double R26_JF_T, double R26_JF_L, double R26_JF_H, double R27_JF_T, double R27_JF_L, double R27_JF_H, double R28_JF_T, double R28_JF_L, double R28_JF_H, double R29_JF_T, double R29_JF_L, double R29_JF_H, double R30_JF_T, double R30_JF_L, double R30_JF_H)
        {
            this.vin = vin; this.datetime = datetime; this.L01_JF_T = L01_JF_T; this.L01_JF_L = L01_JF_L; this.L01_JF_H = L01_JF_H; this.L02_JF_T = L02_JF_T; this.L02_JF_L = L02_JF_L; this.L02_JF_H = L02_JF_H; this.L03_JF_T = L03_JF_T; this.L03_JF_L = L03_JF_L; this.L03_JF_H = L03_JF_H; this.L04_JF_T = L04_JF_T; this.L04_JF_L = L04_JF_L; this.L04_JF_H = L04_JF_H; this.L05_JF_T = L05_JF_T; this.L05_JF_L = L05_JF_L; this.L05_JF_H = L05_JF_H; this.L06_JF_T = L06_JF_T; this.L06_JF_L = L06_JF_L; this.L06_JF_H = L06_JF_H; this.L07_JF_T = L07_JF_T; this.L07_JF_L = L07_JF_L; this.L07_JF_H = L07_JF_H; this.L21_JF_T = L21_JF_T; this.L21_JF_L = L21_JF_L; this.L21_JF_H = L21_JF_H; this.L22_JF_T = L22_JF_T; this.L22_JF_L = L22_JF_L; this.L22_JF_H = L22_JF_H; this.L23_JF_T = L23_JF_T; this.L23_JF_L = L23_JF_L; this.L23_JF_H = L23_JF_H; this.L24_JF_T = L24_JF_T; this.L24_JF_L = L24_JF_L; this.L24_JF_H = L24_JF_H; this.L25_JF_T = L25_JF_T; this.L25_JF_L = L25_JF_L; this.L25_JF_H = L25_JF_H; this.L26_JF_T = L26_JF_T; this.L26_JF_L = L26_JF_L; this.L26_JF_H = L26_JF_H; this.L27_JF_T = L27_JF_T; this.L27_JF_L = L27_JF_L; this.L27_JF_H = L27_JF_H; this.L28_JF_T = L28_JF_T; this.L28_JF_L = L28_JF_L; this.L28_JF_H = L28_JF_H; this.L29_JF_T = L29_JF_T; this.L29_JF_L = L29_JF_L; this.L29_JF_H = L29_JF_H; this.L30_JF_T = L30_JF_T; this.L30_JF_L = L30_JF_L; this.L30_JF_H = L30_JF_H; this.R01_JF_T = R01_JF_T; this.R01_JF_L = R01_JF_L; this.R01_JF_H = R01_JF_H; this.R02_JF_T = R02_JF_T; this.R02_JF_L = R02_JF_L; this.R02_JF_H = R02_JF_H; this.R03_JF_T = R03_JF_T; this.R03_JF_L = R03_JF_L; this.R03_JF_H = R03_JF_H; this.R04_JF_T = R04_JF_T; this.R04_JF_L = R04_JF_L; this.R04_JF_H = R04_JF_H; this.R05_JF_T = R05_JF_T; this.R05_JF_L = R05_JF_L; this.R05_JF_H = R05_JF_H; this.R06_JF_T = R06_JF_T; this.R06_JF_L = R06_JF_L; this.R06_JF_H = R06_JF_H; this.R07_JF_T = R07_JF_T; this.R07_JF_L = R07_JF_L; this.R07_JF_H = R07_JF_H; this.R21_JF_T = R21_JF_T; this.R21_JF_L = R21_JF_L; this.R21_JF_H = R21_JF_H; this.R22_JF_T = R22_JF_T; this.R22_JF_L = R22_JF_L; this.R22_JF_H = R22_JF_H; this.R23_JF_T = R23_JF_T; this.R23_JF_L = R23_JF_L; this.R23_JF_H = R23_JF_H; this.R24_JF_T = R24_JF_T; this.R24_JF_L = R24_JF_L; this.R24_JF_H = R24_JF_H; this.R25_JF_T = R25_JF_T; this.R25_JF_L = R25_JF_L; this.R25_JF_H = R25_JF_H; this.R26_JF_T = R26_JF_T; this.R26_JF_L = R26_JF_L; this.R26_JF_H = R26_JF_H; this.R27_JF_T = R27_JF_T; this.R27_JF_L = R27_JF_L; this.R27_JF_H = R27_JF_H; this.R28_JF_T = R28_JF_T; this.R28_JF_L = R28_JF_L; this.R28_JF_H = R28_JF_H; this.R29_JF_T = R29_JF_T; this.R29_JF_L = R29_JF_L; this.R29_JF_H = R29_JF_H; this.R30_JF_T = R30_JF_T; this.R30_JF_L = R30_JF_L; this.R30_JF_H = R30_JF_H;
        }
        private string vin; public string VIN { get { return vin; } set { vin = value; } }
        private string datetime; public string DATETIME { get { return datetime; } set { datetime = value; } }
        private double l01_JF_T; public double L01_JF_T { get { return l01_JF_T; } set { l01_JF_T = value; } }
        private double l01_JF_L; public double L01_JF_L { get { return l01_JF_L; } set { l01_JF_L = value; } }
        private double l01_JF_H; public double L01_JF_H { get { return l01_JF_H; } set { l01_JF_H = value; } }
        private double l02_JF_T; public double L02_JF_T { get { return l02_JF_T; } set { l02_JF_T = value; } }
        private double l02_JF_L; public double L02_JF_L { get { return l02_JF_L; } set { l02_JF_L = value; } }
        private double l02_JF_H; public double L02_JF_H { get { return l02_JF_H; } set { l02_JF_H = value; } }
        private double l03_JF_T; public double L03_JF_T { get { return l03_JF_T; } set { l03_JF_T = value; } }
        private double l03_JF_L; public double L03_JF_L { get { return l03_JF_L; } set { l03_JF_L = value; } }
        private double l03_JF_H; public double L03_JF_H { get { return l03_JF_H; } set { l03_JF_H = value; } }
        private double l04_JF_T; public double L04_JF_T { get { return l04_JF_T; } set { l04_JF_T = value; } }
        private double l04_JF_L; public double L04_JF_L { get { return l04_JF_L; } set { l04_JF_L = value; } }
        private double l04_JF_H; public double L04_JF_H { get { return l04_JF_H; } set { l04_JF_H = value; } }
        private double l05_JF_T; public double L05_JF_T { get { return l05_JF_T; } set { l05_JF_T = value; } }
        private double l05_JF_L; public double L05_JF_L { get { return l05_JF_L; } set { l05_JF_L = value; } }
        private double l05_JF_H; public double L05_JF_H { get { return l05_JF_H; } set { l05_JF_H = value; } }
        private double l06_JF_T; public double L06_JF_T { get { return l06_JF_T; } set { l06_JF_T = value; } }
        private double l06_JF_L; public double L06_JF_L { get { return l06_JF_L; } set { l06_JF_L = value; } }
        private double l06_JF_H; public double L06_JF_H { get { return l06_JF_H; } set { l06_JF_H = value; } }
        private double l07_JF_T; public double L07_JF_T { get { return l07_JF_T; } set { l07_JF_T = value; } }
        private double l07_JF_L; public double L07_JF_L { get { return l07_JF_L; } set { l07_JF_L = value; } }
        private double l07_JF_H; public double L07_JF_H { get { return l07_JF_H; } set { l07_JF_H = value; } }
        private double l21_JF_T; public double L21_JF_T { get { return l21_JF_T; } set { l21_JF_T = value; } }
        private double l21_JF_L; public double L21_JF_L { get { return l21_JF_L; } set { l21_JF_L = value; } }
        private double l21_JF_H; public double L21_JF_H { get { return l21_JF_H; } set { l21_JF_H = value; } }
        private double l22_JF_T; public double L22_JF_T { get { return l22_JF_T; } set { l22_JF_T = value; } }
        private double l22_JF_L; public double L22_JF_L { get { return l22_JF_L; } set { l22_JF_L = value; } }
        private double l22_JF_H; public double L22_JF_H { get { return l22_JF_H; } set { l22_JF_H = value; } }
        private double l23_JF_T; public double L23_JF_T { get { return l23_JF_T; } set { l23_JF_T = value; } }
        private double l23_JF_L; public double L23_JF_L { get { return l23_JF_L; } set { l23_JF_L = value; } }
        private double l23_JF_H; public double L23_JF_H { get { return l23_JF_H; } set { l23_JF_H = value; } }
        private double l24_JF_T; public double L24_JF_T { get { return l24_JF_T; } set { l24_JF_T = value; } }
        private double l24_JF_L; public double L24_JF_L { get { return l24_JF_L; } set { l24_JF_L = value; } }
        private double l24_JF_H; public double L24_JF_H { get { return l24_JF_H; } set { l24_JF_H = value; } }
        private double l25_JF_T; public double L25_JF_T { get { return l25_JF_T; } set { l25_JF_T = value; } }
        private double l25_JF_L; public double L25_JF_L { get { return l25_JF_L; } set { l25_JF_L = value; } }
        private double l25_JF_H; public double L25_JF_H { get { return l25_JF_H; } set { l25_JF_H = value; } }
        private double l26_JF_T; public double L26_JF_T { get { return l26_JF_T; } set { l26_JF_T = value; } }
        private double l26_JF_L; public double L26_JF_L { get { return l26_JF_L; } set { l26_JF_L = value; } }
        private double l26_JF_H; public double L26_JF_H { get { return l26_JF_H; } set { l26_JF_H = value; } }
        private double l27_JF_T; public double L27_JF_T { get { return l27_JF_T; } set { l27_JF_T = value; } }
        private double l27_JF_L; public double L27_JF_L { get { return l27_JF_L; } set { l27_JF_L = value; } }
        private double l27_JF_H; public double L27_JF_H { get { return l27_JF_H; } set { l27_JF_H = value; } }
        private double l28_JF_T; public double L28_JF_T { get { return l28_JF_T; } set { l28_JF_T = value; } }
        private double l28_JF_L; public double L28_JF_L { get { return l28_JF_L; } set { l28_JF_L = value; } }
        private double l28_JF_H; public double L28_JF_H { get { return l28_JF_H; } set { l28_JF_H = value; } }
        private double l29_JF_T; public double L29_JF_T { get { return l29_JF_T; } set { l29_JF_T = value; } }
        private double l29_JF_L; public double L29_JF_L { get { return l29_JF_L; } set { l29_JF_L = value; } }
        private double l29_JF_H; public double L29_JF_H { get { return l29_JF_H; } set { l29_JF_H = value; } }
        private double l30_JF_T; public double L30_JF_T { get { return l30_JF_T; } set { l30_JF_T = value; } }
        private double l30_JF_L; public double L30_JF_L { get { return l30_JF_L; } set { l30_JF_L = value; } }
        private double l30_JF_H; public double L30_JF_H { get { return l30_JF_H; } set { l30_JF_H = value; } }
        private double r01_JF_T; public double R01_JF_T { get { return r01_JF_T; } set { r01_JF_T = value; } }
        private double r01_JF_L; public double R01_JF_L { get { return r01_JF_L; } set { r01_JF_L = value; } }
        private double r01_JF_H; public double R01_JF_H { get { return r01_JF_H; } set { r01_JF_H = value; } }
        private double r02_JF_T; public double R02_JF_T { get { return r02_JF_T; } set { r02_JF_T = value; } }
        private double r02_JF_L; public double R02_JF_L { get { return r02_JF_L; } set { r02_JF_L = value; } }
        private double r02_JF_H; public double R02_JF_H { get { return r02_JF_H; } set { r02_JF_H = value; } }
        private double r03_JF_T; public double R03_JF_T { get { return r03_JF_T; } set { r03_JF_T = value; } }
        private double r03_JF_L; public double R03_JF_L { get { return r03_JF_L; } set { r03_JF_L = value; } }
        private double r03_JF_H; public double R03_JF_H { get { return r03_JF_H; } set { r03_JF_H = value; } }
        private double r04_JF_T; public double R04_JF_T { get { return r04_JF_T; } set { r04_JF_T = value; } }
        private double r04_JF_L; public double R04_JF_L { get { return r04_JF_L; } set { r04_JF_L = value; } }
        private double r04_JF_H; public double R04_JF_H { get { return r04_JF_H; } set { r04_JF_H = value; } }
        private double r05_JF_T; public double R05_JF_T { get { return r05_JF_T; } set { r05_JF_T = value; } }
        private double r05_JF_L; public double R05_JF_L { get { return r05_JF_L; } set { r05_JF_L = value; } }
        private double r05_JF_H; public double R05_JF_H { get { return r05_JF_H; } set { r05_JF_H = value; } }
        private double r06_JF_T; public double R06_JF_T { get { return r06_JF_T; } set { r06_JF_T = value; } }
        private double r06_JF_L; public double R06_JF_L { get { return r06_JF_L; } set { r06_JF_L = value; } }
        private double r06_JF_H; public double R06_JF_H { get { return r06_JF_H; } set { r06_JF_H = value; } }
        private double r07_JF_T; public double R07_JF_T { get { return r07_JF_T; } set { r07_JF_T = value; } }
        private double r07_JF_L; public double R07_JF_L { get { return r07_JF_L; } set { r07_JF_L = value; } }
        private double r07_JF_H; public double R07_JF_H { get { return r07_JF_H; } set { r07_JF_H = value; } }
        private double r21_JF_T; public double R21_JF_T { get { return r21_JF_T; } set { r21_JF_T = value; } }
        private double r21_JF_L; public double R21_JF_L { get { return r21_JF_L; } set { r21_JF_L = value; } }
        private double r21_JF_H; public double R21_JF_H { get { return r21_JF_H; } set { r21_JF_H = value; } }
        private double r22_JF_T; public double R22_JF_T { get { return r22_JF_T; } set { r22_JF_T = value; } }
        private double r22_JF_L; public double R22_JF_L { get { return r22_JF_L; } set { r22_JF_L = value; } }
        private double r22_JF_H; public double R22_JF_H { get { return r22_JF_H; } set { r22_JF_H = value; } }
        private double r23_JF_T; public double R23_JF_T { get { return r23_JF_T; } set { r23_JF_T = value; } }
        private double r23_JF_L; public double R23_JF_L { get { return r23_JF_L; } set { r23_JF_L = value; } }
        private double r23_JF_H; public double R23_JF_H { get { return r23_JF_H; } set { r23_JF_H = value; } }
        private double r24_JF_T; public double R24_JF_T { get { return r24_JF_T; } set { r24_JF_T = value; } }
        private double r24_JF_L; public double R24_JF_L { get { return r24_JF_L; } set { r24_JF_L = value; } }
        private double r24_JF_H; public double R24_JF_H { get { return r24_JF_H; } set { r24_JF_H = value; } }
        private double r25_JF_T; public double R25_JF_T { get { return r25_JF_T; } set { r25_JF_T = value; } }
        private double r25_JF_L; public double R25_JF_L { get { return r25_JF_L; } set { r25_JF_L = value; } }
        private double r25_JF_H; public double R25_JF_H { get { return r25_JF_H; } set { r25_JF_H = value; } }
        private double r26_JF_T; public double R26_JF_T { get { return r26_JF_T; } set { r26_JF_T = value; } }
        private double r26_JF_L; public double R26_JF_L { get { return r26_JF_L; } set { r26_JF_L = value; } }
        private double r26_JF_H; public double R26_JF_H { get { return r26_JF_H; } set { r26_JF_H = value; } }
        private double r27_JF_T; public double R27_JF_T { get { return r27_JF_T; } set { r27_JF_T = value; } }
        private double r27_JF_L; public double R27_JF_L { get { return r27_JF_L; } set { r27_JF_L = value; } }
        private double r27_JF_H; public double R27_JF_H { get { return r27_JF_H; } set { r27_JF_H = value; } }
        private double r28_JF_T; public double R28_JF_T { get { return r28_JF_T; } set { r28_JF_T = value; } }
        private double r28_JF_L; public double R28_JF_L { get { return r28_JF_L; } set { r28_JF_L = value; } }
        private double r28_JF_H; public double R28_JF_H { get { return r28_JF_H; } set { r28_JF_H = value; } }
        private double r29_JF_T; public double R29_JF_T { get { return r29_JF_T; } set { r29_JF_T = value; } }
        private double r29_JF_L; public double R29_JF_L { get { return r29_JF_L; } set { r29_JF_L = value; } }
        private double r29_JF_H; public double R29_JF_H { get { return r29_JF_H; } set { r29_JF_H = value; } }
        private double r30_JF_T; public double R30_JF_T { get { return r30_JF_T; } set { r30_JF_T = value; } }
        private double r30_JF_L; public double R30_JF_L { get { return r30_JF_L; } set { r30_JF_L = value; } }
        private double r30_JF_H; public double R30_JF_H { get { return r30_JF_H; } set { r30_JF_H = value; } }
    }
}
