using System;
using System.Drawing;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ThoughtWorks.QRCode.Codec;
using BarcodeLib;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Security.Cryptography;
using System.IO.Compression;
using System.Reflection;
using System.Management;
using System.Runtime.InteropServices;

namespace Basiclibrarycode.Ydw
{
    public class publicUtility
    {
        #region  数据格式转换

        #region 1、将Bitmap转成Base64的字符串  2020.10.29
        /// <summary>
        /// 将Bitmap转成Base64的字符串，调用返回时，将转换成base64的码前面加上：Url = "data:image/png;base64," + base64Img;
        /// </summary>
        /// <param name="bmp">Bitmap格式图片数据</param>
        /// <returns>返回base64字符串</returns>
        public static string ImgBitmapToBase64String(Bitmap bmp)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                return Convert.ToBase64String(arr);
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region Base64的图片数据转成Bitmap图片
        /// <summary>
        /// Base64的图片数据转成Bitmap图片
        /// </summary>
        /// <param name="strbase64">Base64字符串</param>
        /// <returns></returns>
        public static Bitmap Base64StringToImageBitmap(string strbase64)
        {
            try
            {
                byte[] arr = Convert.FromBase64String(strbase64);
                MemoryStream ms = new MemoryStream(arr);
                Bitmap bmp = new Bitmap(ms);
                ms.Close();
                return bmp;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion


        #endregion

        #region 验证数据

        #region 1、验证是否正确的ip地址  2020.10.29
        /// <summary>
        /// 验证是否正确的ip地址
        /// </summary>
        public static bool IsIpAddress(string value)
        {
            return Regex.IsMatch(value, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }
        #endregion

        #region 2、验证是否正确的电话号码  2020.10.29
        /// <summary>
        /// 验证是否正确的电话号码
        /// </summary>
        public static bool IsPhone(string value)
        {
            return Regex.IsMatch(value, @"^(\d{3,4}\-?)?[0-9]\d{6,8}(\-([0-9]{3,4}))?$");
        }
        #endregion

        #region 3、验证是否正确的手机号码  2020.10.29
        /// <summary>
        /// 验证是否正确的手机号码
        /// </summary>
        public static bool IsMobile(string value)
        {
            return Regex.IsMatch(value, @"^1[3|4|5|8][0-9]{9}$");
        }
        #endregion

        #region 4、验证是否是正确的Url  2020.10.29
        /// <summary>
        /// 验证是否是正确的Url
        /// </summary>
        public static bool IsUrl(string value)
        {
            return Regex.IsMatch(value, @"^(http|https)\://([a-zA-Z0-9\.\-]+(\:[a-zA-Z0-9\.&%\$\-]+)*@)*((25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])|localhost|([a-zA-Z0-9\-]+\.)*[a-zA-Z0-9\-]+\.(com|edu|gov|int|mil|net|org|biz|arpa|info|name|pro|aero|coop|museum|[a-zA-Z]{1,10}))(\:[0-9]+)*(/($|[a-zA-Z0-9\.\,\?\'\\\+&%\$#\=~_\-]+))*$");
        }
        #endregion

        #endregion

        #region 日期相关操作

        #region 1、根据生日获取年龄  2020.10.22
        /// <summary>
        /// 根据生日获取年龄：输入的出生日期格式为2020.10.22、2020-10-22、2020/10/22
        /// 根据生日计算出准确的年龄，不等于0时，返回的是岁，等于0时，返回的是天(以‘-’来区分)
        /// </summary>
        /// <param name="Birthdate">出生日期</param>
        /// <returns></returns>
        public static string GetAgeByBirth(string Birthdate)
        {
            string ages = string.Empty;
            try
            {
                //年龄格式化
                DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                dtFormat.ShortDatePattern = "yyyy-MM-dd";
                DateTime dt = Convert.ToDateTime(Birthdate, dtFormat);
                int age = DateTime.Now.Year - dt.Year;
                if (DateTime.Now.Month < dt.Month || (DateTime.Now.Month == dt.Month && DateTime.Now.Day < dt.Day)) age--;
                TimeSpan ts = DateTime.Now - dt;
                ages = age == 0 ? "-" + ts.Days : age.ToString();
            }
            catch (Exception ex)
            {
                return "根据生日获取年龄失败：" + ex;
            }

            return ages;
        }
        #endregion

        #region 2、传入当前年月日，获取古历  2020.10.25

        #region 公共调用方法
        public string[] GetChineseDateTime(DateTime datetime) //根据公历获取农历日期
        {
            int year = ChineseCalendar.GetYear(datetime);
            int month = ChineseCalendar.GetMonth(datetime);
            int day = ChineseCalendar.GetDayOfMonth(datetime);
            int leapMonth = ChineseCalendar.GetLeapMonth(year); //获取闰月， 0 则表示没有闰月
            bool isleap = false;
            if (leapMonth > 0)
            {
                if (leapMonth == month)
                {
                    //闰月
                    isleap = true;
                    month--;
                }
                else if (month > leapMonth)
                {
                    month--;
                }
            }
            string nl = string.Concat(GetLunisolarYear(year), "/", isleap ? "闰" : string.Empty, GetLunisolarMonth(month), "/", GetLunisolarDay(day));
            return nl.Split('/');
        }
        #endregion

        #region 公共变量
        // 实例化一个 ChineseLunisolarCalendar
        private static ChineseLunisolarCalendar ChineseCalendar = new ChineseLunisolarCalendar();
        //十天干数组
        private static string[] tg = { "甲", "乙", "丙", "丁", "戊", "己", "庚", "辛", "壬", "癸" };
        //十二地支数组
        private static string[] dz = { "子", "丑", "寅", "卯", "辰", "巳", "午", "未", "申", "酉", "戌", "亥" };
        //十二生肖数组
        private static string[] sx = { "鼠", "牛", "虎", "免", "龙", "蛇", "马", "羊", "猴", "鸡", "狗", "猪" };
        //农历月数组
        private static string[] months = { "正", "二", "三", "四", "五", "六", "七", "八", "九", "十", "十一", "十二(腊)" };
        //农历日1数组
        private static string[] days1 = { "初", "十", "廿", "三" };
        //农历日2数组
        private static string[] days = { "一", "二", "三", "四", "五", "六", "七", "八", "九", "十" };
        #endregion

        #region 辅助方法
        private object GetLunisolarDay(int day)  //返回农历日
        {
            if (day > 0 && day < 32)
            {
                if (day != 20 && day != 30)
                {
                    return string.Concat(days1[(day - 1) / 10], days[(day - 1) % 10]);
                }
                else
                {
                    return string.Concat(days[(day - 1) / 10], days1[1]);
                }
            }
            throw new ArgumentOutOfRangeException("无效的日!");
        }
        private object GetLunisolarMonth(int month)  //返回农历月份
        {
            if (month < 13 && month > 0)
            {
                return months[month - 1];
            }
            throw new ArgumentOutOfRangeException("无效的月份!");
        }
        private object GetLunisolarYear(int year)    //返回农历天干地支年 
        {
            if (year > 3)
            {
                int tgIndex = (year - 4) % 10;
                int dzIndex = (year - 4) % 12;
                return string.Concat(tg[tgIndex], dz[dzIndex], "[", sx[dzIndex], "]");
            }
            throw new ArgumentOutOfRangeException("无效的年份!");
        }
        #endregion

        #endregion

        #region 3、获取当前星期  2020.10.25
        /// <summary>
        /// 获取当前星期:
        /// 传入整数0为格式（星期一、星期二、星期三、星期四、星期五、星期六、星期天），
        /// 传入整数1为格式（周一、周二、周三、周四、周五、周六、周末）。
        /// </summary>
        /// <param name="type">获取星期的格式</param>
        /// <returns>返回当前星期</returns>
        public static string GetWeek(int type)
        {
            string[] weeks = { "", "", "", "", "", "", "" };
            switch (type)
            {
                case 0:
                    weeks[0] = "星期一"; weeks[1] = "星期二"; weeks[2] = "星期三";
                    weeks[3] = "星期四"; weeks[4] = "星期五"; weeks[5] = "星期六";
                    weeks[6] = "星期天";
                    break;
                case 1:
                    weeks[0] = "周一"; weeks[1] = "周二"; weeks[2] = "周三";
                    weeks[3] = "周四"; weeks[4] = "周五"; weeks[5] = "周六";
                    weeks[6] = "周末";
                    break;
            }
            string week = "";
            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday": week = weeks[0]; break;
                case "Tuesday": week = weeks[1]; break;
                case "Wednesday": week = weeks[2]; break;
                case "Thursday": week = weeks[3]; break;
                case "Friday": week = weeks[4]; break;
                case "Saturday": week = weeks[5]; break;
                case "Sunday": week = weeks[6]; break;
            }
            return week;
        }
        #endregion

        #region 4、根据公历日期获取星座  2020.10.25
        /// <summary>
        /// 根据公历日期获取星座:调用方法ps:GeConstellation(DateTime.Now)
        /// </summary>
        /// <param name="birthday">日期</param>
        /// <returns>星座字符串</returns>
        public static string GeConstellation(DateTime birthday)
        {
            float birthdayF = 0.00F;
            if (birthday.Month == 1 && birthday.Day < 20)
            {
                birthdayF = float.Parse(string.Format("13.{0}", birthday.Day));
            }
            else
            {
                birthdayF = float.Parse(string.Format("{0}.{1}", birthday.Month, birthday.Day));
            }
            float[] atomBound = { 1.20F, 2.20F, 3.21F, 4.21F, 5.21F, 6.22F, 7.23F, 8.23F, 9.23F, 10.23F, 11.21F, 12.22F, 13.20F };
            string[] atoms = { "水瓶座", "双鱼座", "白羊座", "金牛座", "双子座", "巨蟹座", "狮子座", "处女座", "天秤座", "天蝎座", "射手座", "魔羯座" };

            string ret = "";
            for (int i = 0; i < atomBound.Length - 1; i++)
            {
                if (atomBound[i] <= birthdayF && atomBound[i + 1] > birthdayF)
                {
                    ret = atoms[i];
                    break;
                }
            }
            return ret == "" ? "魔羯座" : ret;
        }
        #endregion

        #region 5、根据农历日期获取中国节日  2020.10.25

        #region 公共调用方法
        /// <summary>
        /// 根据农历日期获取中国节日：调用方法ps：GetChineseCalendar(DateTime.Now)
        /// </summary>
        /// <param name="birthday">当前日期</param>
        /// <returns>返回节日字符串</returns>
        public static string GetChineseCalendar(DateTime birthday)
        {
            publicUtility t = new publicUtility();
            string[] nl = t.GetChineseDateTime(birthday);
            int months = 0, days = 0;
            switch (nl[1])
            {
                case "正": months = 1; break;
                case "二": months = 2; break;
                case "三": months = 3; break;
                case "四": months = 4; break;
                case "五": months = 5; break;
                case "六": months = 6; break;
                case "七": months = 7; break;
                case "八": months = 8; break;
                case "九": months = 9; break;
                case "十": months = 10; break;
                case "十一": months = 11; break;
                case "十二(腊)": months = 12; break;
            }
            switch (nl[2])
            {
                case "初一": days = 1; break;
                case "初二": days = 2; break;
                case "初三": days = 3; break;
                case "初四": days = 4; break;
                case "初五": days = 5; break;
                case "初六": days = 6; break;
                case "初七": days = 7; break;
                case "初八": days = 8; break;
                case "初九": days = 9; break;
                case "初十": days = 10; break;
                case "十一": days = 11; break;
                case "十二": days = 12; break;
                case "十三": days = 13; break;
                case "十四": days = 14; break;
                case "十五": days = 15; break;
                case "十六": days = 16; break;
                case "十七": days = 17; break;
                case "十八": days = 18; break;
                case "十九": days = 19; break;
                case "二十": days = 20; break;
                case "廿一": days = 21; break;
                case "廿二": days = 22; break;
                case "廿三": days = 23; break;
                case "廿四": days = 24; break;
                case "廿五": days = 25; break;
                case "廿六": days = 26; break;
                case "廿七": days = 27; break;
                case "廿八": days = 28; break;
                case "廿九": days = 29; break;
                case "三十": days = 30; break;
                case "三十一": days = 31; break;
            }

            string tempStr = "";
            foreach (LunarHolidayStruct lh in lHolidayInfo)
            {
                if ((lh.Month == months) && (lh.Day == days))
                {
                    tempStr = lh.HolidayName;
                    break;
                }
            }
            //对除夕进行特别处理
            if (months == 12)
            {
                publicUtility ut = new publicUtility();
                int i = ut.GetChineseMonthDays(birthday.Year, 12); //计算当年农历12月的总天数
                if (days == i) //如果为最后一天
                {
                    tempStr = "除夕";
                }
            }
            return tempStr;
        }
        #endregion

        #region 辅助方法

        #region 传回农历y年m月的总天数 GetChineseMonthDays
        /// <summary>
        /// 传回农历y年m月的总天数
        /// </summary>
        private int GetChineseMonthDays(int year, int month)
        {
            if (BitTest32((LunarDateArray[year - MinYear] & 0x0000FFFF), (16 - month)))
            {
                return 30;
            }
            else
            {
                return 29;
            }
        }
        #endregion

        #region 农历的节日集合
        private static LunarHolidayStruct[] lHolidayInfo = new LunarHolidayStruct[]{
            new LunarHolidayStruct(1, 1, 1, "春节"),
            new LunarHolidayStruct(1, 15, 0, "元宵节"),
            new LunarHolidayStruct(2, 2, 0, "土地诞（龙抬头）"),
            new LunarHolidayStruct(3, 3, 0, "上巳节"),
            new LunarHolidayStruct(5, 5, 0, "端午节"),
            new LunarHolidayStruct(7, 7, 0, "七夕情人节"),
            new LunarHolidayStruct(7, 14, 0, "中元节（盂兰盆节）"),
            new LunarHolidayStruct(7, 15, 0, "中元节（盂兰盆节）"),
            new LunarHolidayStruct(8, 15, 0, "中秋节"),
            new LunarHolidayStruct(9, 9, 0, "重阳节"),
            new LunarHolidayStruct(10, 1, 0, "寒衣节"),
            new LunarHolidayStruct(12, 8, 0, "腊八节"),
            new LunarHolidayStruct(12, 23, 0, "北方小年(扫房)"),
            new LunarHolidayStruct(12, 24, 0, "南方小年(掸尘)"),
            //new LunarHolidayStruct(12, 30, 0, "除夕")  //注意除夕需要其它方法进行计算
        };
        #endregion

        #region 农历放假天数和节日
        /// <summary>
        /// 农历放假天数和节日
        /// </summary>
        private struct LunarHolidayStruct
        {
            public int Month;
            public int Day;
            public int Recess;
            public string HolidayName;

            public LunarHolidayStruct(int month, int day, int recess, string name)
            {
                Month = month;
                Day = day;
                Recess = recess;
                HolidayName = name;
            }
        }
        #endregion

        #region 测试某位是否为真 BitTest32
        /// <summary>
        /// 测试某位是否为真
        /// </summary>
        private bool BitTest32(int num, int bitpostion)
        {
            if ((bitpostion > 31) || (bitpostion < 0))
                throw new Exception("Error Param: bitpostion[0-31]:" + bitpostion.ToString());

            int bit = 1 << bitpostion;

            if ((num & bit) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region 阴历数据
        /// <summary>
        /// 来源于网上的农历数据
        /// </summary>
        /// <remarks>
        /// 数据结构如下，共使用17位数据
        /// 第17位：表示闰月天数，0表示29天   1表示30天
        /// 第16位-第5位（共12位）表示12个月，其中第16位表示第一月，如果该月为30天则为1，29天为0
        /// 第4位-第1位（共4位）表示闰月是哪个月，如果当年没有闰月，则置0
        ///</remarks>
        private static int[] LunarDateArray = new int[]{
                0x04BD8,0x04AE0,0x0A570,0x054D5,0x0D260,0x0D950,0x16554,0x056A0,0x09AD0,0x055D2,
                0x04AE0,0x0A5B6,0x0A4D0,0x0D250,0x1D255,0x0B540,0x0D6A0,0x0ADA2,0x095B0,0x14977,
                0x04970,0x0A4B0,0x0B4B5,0x06A50,0x06D40,0x1AB54,0x02B60,0x09570,0x052F2,0x04970,
                0x06566,0x0D4A0,0x0EA50,0x06E95,0x05AD0,0x02B60,0x186E3,0x092E0,0x1C8D7,0x0C950,
                0x0D4A0,0x1D8A6,0x0B550,0x056A0,0x1A5B4,0x025D0,0x092D0,0x0D2B2,0x0A950,0x0B557,
                0x06CA0,0x0B550,0x15355,0x04DA0,0x0A5B0,0x14573,0x052B0,0x0A9A8,0x0E950,0x06AA0,
                0x0AEA6,0x0AB50,0x04B60,0x0AAE4,0x0A570,0x05260,0x0F263,0x0D950,0x05B57,0x056A0,
                0x096D0,0x04DD5,0x04AD0,0x0A4D0,0x0D4D4,0x0D250,0x0D558,0x0B540,0x0B6A0,0x195A6,
                0x095B0,0x049B0,0x0A974,0x0A4B0,0x0B27A,0x06A50,0x06D40,0x0AF46,0x0AB60,0x09570,
                0x04AF5,0x04970,0x064B0,0x074A3,0x0EA50,0x06B58,0x055C0,0x0AB60,0x096D5,0x092E0,
                0x0C960,0x0D954,0x0D4A0,0x0DA50,0x07552,0x056A0,0x0ABB7,0x025D0,0x092D0,0x0CAB5,
                0x0A950,0x0B4A0,0x0BAA4,0x0AD50,0x055D9,0x04BA0,0x0A5B0,0x15176,0x052B0,0x0A930,
                0x07954,0x06AA0,0x0AD50,0x05B52,0x04B60,0x0A6E6,0x0A4E0,0x0D260,0x0EA65,0x0D530,
                0x05AA0,0x076A3,0x096D0,0x04BD7,0x04AD0,0x0A4D0,0x1D0B6,0x0D250,0x0D520,0x0DD45,
                0x0B5A0,0x056D0,0x055B2,0x049B0,0x0A577,0x0A4B0,0x0AA50,0x1B255,0x06D20,0x0ADA0,
                0x14B63
                };
        #endregion


        #region 基本常量
        private const int MinYear = 1900;
        #endregion

        #endregion

        #endregion

        #region 6、根据公历日期获取国际节日  2020.10.25

        #region 公共调用方法
        /// <summary>
        /// 根据公历日期获取国际节日:调用方法ps:GetInternationalCalendar(DateTime.Now)
        /// </summary>
        /// <param name="birthday">当前日期</param>
        /// <returns>返回节日字符串</returns>
        public static string GetInternationalCalendar(DateTime birthday)
        {
            string tempStr = "";
            foreach (SolarHolidayStruct sh in sHolidayInfo)
            {
                if ((sh.Month == birthday.Month) && (sh.Day == birthday.Day))
                {
                    tempStr = sh.HolidayName;
                    break;
                }
            }
            return tempStr;
        }
        #endregion

        #region 按公历计算的节日
        private static SolarHolidayStruct[] sHolidayInfo = new SolarHolidayStruct[]{
            new SolarHolidayStruct(1, 1, 1, "元旦"),
            new SolarHolidayStruct(2, 2, 0, "世界湿地日"),
            new SolarHolidayStruct(2, 10, 0, "国际气象节"),
            new SolarHolidayStruct(2, 14, 0, "情人节"),
            new SolarHolidayStruct(3, 1, 0, "国际海豹日"),
            new SolarHolidayStruct(3, 3, 0, "国际爱耳日"),
            new SolarHolidayStruct(3, 5, 0, "学雷锋纪念日"),
            new SolarHolidayStruct(3, 8, 0, "妇女节"),
            new SolarHolidayStruct(3, 12, 0, "植树节 孙中山逝世纪念日"),
            new SolarHolidayStruct(3, 14, 0, "国际警察日"),
            new SolarHolidayStruct(3, 15, 0, "消费者权益日"),
            new SolarHolidayStruct(3, 17, 0, "中国国医节 国际航海日"),
            new SolarHolidayStruct(3, 21, 0, "世界森林日 消除种族歧视国际日 世界儿歌日"),
            new SolarHolidayStruct(3, 22, 0, "世界水日"),
            new SolarHolidayStruct(3, 24, 0, "世界防治结核病日"),
            new SolarHolidayStruct(4, 1, 0, "愚人节"),
            new SolarHolidayStruct(4, 7, 0, "世界卫生日"),
            new SolarHolidayStruct(4, 22, 0, "世界地球日"),
            new SolarHolidayStruct(5, 1, 1, "劳动节"),
            new SolarHolidayStruct(5, 2, 1, "劳动节假日"),
            new SolarHolidayStruct(5, 3, 1, "劳动节假日"),
            new SolarHolidayStruct(5, 4, 0, "青年节"),
            new SolarHolidayStruct(5, 8, 0, "世界红十字日"),
            new SolarHolidayStruct(5, 12, 0, "国际护士节"),
            new SolarHolidayStruct(5, 31, 0, "世界无烟日"),
            new SolarHolidayStruct(6, 1, 0, "国际儿童节"),
            new SolarHolidayStruct(6, 5, 0, "世界环境保护日"),
            new SolarHolidayStruct(6, 26, 0, "国际禁毒日"),
            new SolarHolidayStruct(7, 1, 0, "建党节 香港回归纪念 世界建筑日"),
            new SolarHolidayStruct(7, 11, 0, "世界人口日"),
            new SolarHolidayStruct(8, 1, 0, "建军节"),
            new SolarHolidayStruct(8, 8, 0, "中国男子节 父亲节"),
            new SolarHolidayStruct(8, 15, 0, "抗日战争胜利纪念"),
            new SolarHolidayStruct(9, 9, 0, "毛主席逝世纪念"),
            new SolarHolidayStruct(9, 10, 0, "教师节"),
            new SolarHolidayStruct(9, 18, 0, "九·一八事变纪念日"),
            new SolarHolidayStruct(9, 20, 0, "国际爱牙日"),
            new SolarHolidayStruct(9, 27, 0, "世界旅游日"),
            new SolarHolidayStruct(9, 28, 0, "孔子诞辰"),
            new SolarHolidayStruct(10, 1, 1, "国庆节 国际音乐日"),
            new SolarHolidayStruct(10, 2, 1, "国庆节假日"),
            new SolarHolidayStruct(10, 3, 1, "国庆节假日"),
            new SolarHolidayStruct(10, 6, 0, "老人节"),
            new SolarHolidayStruct(10, 24, 0, "联合国日"),
            new SolarHolidayStruct(11, 10, 0, "世界青年节"),
            new SolarHolidayStruct(11, 12, 0, "孙中山诞辰纪念"),
            new SolarHolidayStruct(12, 1, 0, "世界艾滋病日"),
            new SolarHolidayStruct(12, 3, 0, "世界残疾人日"),
            new SolarHolidayStruct(12, 20, 0, "澳门回归纪念"),
            new SolarHolidayStruct(12, 24, 0, "平安夜"),
            new SolarHolidayStruct(12, 25, 0, "圣诞节"),
            new SolarHolidayStruct(12, 26, 0, "毛主席诞辰纪念")
           };
        #endregion

        #region 阳历放假天数和节日
        /// <summary>
        /// 阳历放假天数和节日
        /// </summary>
        private struct SolarHolidayStruct
        {
            public int Month;
            public int Day;
            public int Recess; //假期长度
            public string HolidayName;
            public SolarHolidayStruct(int month, int day, int recess, string name)
            {
                Month = month;
                Day = day;
                Recess = recess;
                HolidayName = name;
            }
        }
        #endregion

        #endregion

        #region 7、根据日期获取二十四节气  2020.10.25

        #region 公共调用方法
        /// <summary>
        /// 根据日期获取二十四节气
        /// </summary>
        /// <param name="birthday">当前日期</param>
        /// <returns>返回节气字符串</returns>
        public static string ChineseTwentyFourDay(DateTime birthday)
        {
            DateTime baseDateAndTime = new DateTime(1900, 1, 6, 2, 5, 0); //#1/6/1900 2:05:00 AM#
            DateTime newDate;
            double num;
            int y;
            string tempStr = "";
            y = birthday.Year;
            for (int i = 1; i <= 24; i++)
            {
                num = 525948.76 * (y - 1900) + sTermInfo[i - 1];

                newDate = baseDateAndTime.AddMinutes(num);//按分钟计算
                if (newDate.DayOfYear == birthday.DayOfYear)
                {
                    tempStr = SolarTerm[i - 1];
                    break;
                }
            }
            return tempStr;
        }
        #endregion

        #region 节气数据
        private static string[] SolarTerm = new string[] { "小寒", "大寒", "立春", "雨水", "惊蛰", "春分", "清明", "谷雨", "立夏", "小满", "芒种", "夏至", "小暑", "大暑", "立秋", "处暑", "白露", "秋分", "寒露", "霜降", "立冬", "小雪", "大雪", "冬至" };
        private static int[] sTermInfo = new int[] { 0, 21208, 42467, 63836, 85337, 107014, 128867, 150921, 173149, 195551, 218072, 240693, 263343, 285989, 308563, 331033, 353350, 375494, 397447, 419210, 440795, 462224, 483532, 504758 };
        #endregion

        #endregion


        #endregion

        #region 常用加密算法

        #region 1、MD5加密:字符串加密/数据流加密  2020.10.29

        #region MD5字符串加密
        /// <summary>
        /// MD5加密:参数：将要加密的明文、加密的位数、大小写加密类型(1大写、0小写)
        /// </summary>
        /// <param name="ConvertString">明文</param>
        /// <param name="bit">加密位数</param>
        /// <param name="stype">大小写类型</param>
        /// <returns>返回密文</returns>
        public static string GetMd5Str(string ConvertString, int bit, int stype)
        {
            if (ConvertString.Equals(string.Empty)) return null;
            string ciphertext = "";
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            switch (bit)
            {
                case 8:
                    ciphertext = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(ConvertString)), 2, 4);
                    break;
                case 16:
                    ciphertext = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(ConvertString)), 4, 8);
                    break;
                case 32:
                    ciphertext = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(ConvertString)));
                    break;
            }
            ciphertext = ciphertext.Replace("-", "");
            if (stype == 0) ciphertext = ciphertext.ToLower();//将字符串中所有的大写字母转换成小写字母
            return ciphertext;
        }
        #endregion

        #region MD5数据流加密
        public static string GenerateMD5(Stream inputStream)
        {
            using (MD5 mi = MD5.Create())
            {
                //开始加密
                byte[] newBuffer = mi.ComputeHash(inputStream);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < newBuffer.Length; i++)
                {
                    sb.Append(newBuffer[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        #endregion

        #endregion

        /// <summary>
        /// DES加密
        /// </summary>
        /// <param name="str">需要加密的</param>
        /// <param name="sKey">密匙</param>
        /// <returns></returns>
        public static string DESEncrypt(string str, string sKey)
        {
            try
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputByteArray = Encoding.Default.GetBytes(str);
                des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);// 密匙
                des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);// 初始化向量
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                var retB = Convert.ToBase64String(ms.ToArray());
                return retB;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        /// <summary>
        /// DES解密
        /// </summary>
        /// <param name="pToDecrypt">需要解密的</param>
        /// <param name="sKey">密匙</param>
        /// <returns></returns>
        public static string DESDecrypt(string pToDecrypt, string sKey)
        {
            try
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputByteArray = Convert.FromBase64String(pToDecrypt);
                des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                // 如果两次密匙不一样，这一步可能会引发异常
                cs.FlushFinalBlock();
                return System.Text.Encoding.Default.GetString(ms.ToArray());
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion

        #region 通用功能方法

        #region 1、生成验证码图片  2020.10.22

        #region 对外调用公共方法
        /// <summary>
        /// 生成校验码图片
        /// </summary>
        /// <param name="code">验证码</param>
        /// <returns></returns>
        public Bitmap CreateImage(string code)
        {
            int fSize = FontSize;
            int fWidth = fSize + Padding;
            int imageWidth = (int)(code.Length * fWidth) + 4 + Padding * 2;
            int imageHeight = fSize * 2 + Padding * 2;
            System.Drawing.Bitmap image = new System.Drawing.Bitmap(imageWidth, imageHeight);
            Graphics g = Graphics.FromImage(image);
            g.Clear(BackgroundColor);
            //给背景添加随机生成的燥点
            if (this.Chaos)
            {
                Pen pen = new Pen(ChaosColor, 0);
                int c = Length * 10;
                for (int i = 0; i < c; i++)
                {
                    int x = rndNumber.Next(image.Width);
                    int y = rndNumber.Next(image.Height);

                    g.DrawRectangle(pen, x, y, 1, 1);
                }
            }
            int left = 0, top = 0, top1 = 1, top2 = 1;
            int n1 = (imageHeight - FontSize - Padding * 2);
            int n2 = n1 / 4;
            top1 = n2;
            top2 = n2 * 2;
            Font f;
            Brush b;
            int cindex, findex;
            //随机字体和颜色的验证码字符
            for (int i = 0; i < code.Length; i++)
            {
                cindex = rndNumber.Next(Colors.Length - 1);
                findex = rndNumber.Next(Fonts.Length - 1);
                f = new System.Drawing.Font(Fonts[findex], fSize, System.Drawing.FontStyle.Bold);
                b = new System.Drawing.SolidBrush(Colors[cindex]);
                if (i % 2 == 1)
                {
                    top = top2;
                }
                else
                {
                    top = top1;
                }
                left = i * fWidth;
                g.DrawString(code.Substring(i, 1), f, b, left, top);
            }
            //画一个边框 边框颜色为Color.Gainsboro
            g.DrawRectangle(new Pen(Color.Gainsboro, 0), 0, 0, image.Width - 1, image.Height - 1);
            g.Dispose();
            //产生波形（Add By 51aspx.com）
            //image = TwistImage(image, true, 8, 4);
            image = TwistImage(image, false, 0, 0);
            return image;
        }
        #endregion

        #region 生成验证码图片辅助工具
        /// <summary>
        /// 全局随机数生成器
        /// </summary>
        private Random rndNumber;
        public publicUtility()
        {
            rndNumber = new Random(unchecked((int)DateTime.Now.Ticks));
        }
        // 验证码长度(默认6个验证码的长度)
        int length = 5;
        private int Length
        {
            get { return length; }
            set { length = value; }
        }
        //验证码字体大小
        // int fontSize = 18;
        int fontSize = 18;
        private int FontSize
        {
            get { return fontSize; }
            set { fontSize = value; }
        }
        // 边框补(默认4像素)
        //int padding = 4;
        int padding = 4;
        private int Padding
        {
            get { return padding; }
            set { padding = value; }
        }
        // 是否输出燥点(默认输出)
        bool chaos = true;
        private bool Chaos
        {
            get { return chaos; }
            set { chaos = value; }
        }
        // 输出燥点的颜色(默认灰色)
        Color chaosColor = Color.LightGray;
        private Color ChaosColor
        {
            get { return chaosColor; }
            set { chaosColor = value; }
        }
        // 自定义背景色(默认白色)
        Color backgroundColor = Color.White;
        private Color BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; }
        }
        // 自定义随机颜色数组
        Color[] colors = { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple };
        private Color[] Colors
        {
            get { return colors; }
            set { colors = value; }
        }
        // 自定义字体数组
        string[] fonts = { "Arial", "Georgia" };
        private string[] Fonts
        {
            get { return fonts; }
            set { fonts = value; }
        }
        #region 产生扭曲图片
        private const double PI = 3.1415926535897932384626433832795;
        private const double PI2 = 6.283185307179586476925286766559;
        //private const double PI =0;
        //private const double PI2 =0;
        /// <summary>
        /// 该方法用于扭曲图片
        /// </summary>
        /// <param name="srcBmp">图片路径</param>
        /// <param name="bXDir">如果扭曲则选择为True</param>
        /// <param name="nMultValue">波形的幅度倍数，越大扭曲的程度越高，一般为3</param>
        /// <param name="dPhase">波形的起始相位，取值区间[0-2*PI)</param>
        /// <returns></returns>
        private System.Drawing.Bitmap TwistImage(Bitmap srcBmp, bool bXDir, double dMultValue, double dPhase)
        {
            System.Drawing.Bitmap destBmp = new Bitmap(srcBmp.Width, srcBmp.Height);//创建Bitmap对象
                                                                                    // 将位图背景填充为白色
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(destBmp);//创建Graphics对象
            g.FillRectangle(new SolidBrush(System.Drawing.Color.White), 0, 0, destBmp.Width, destBmp.Height);//将位图背景填充为白色
            g.Dispose();//释放raphics对象
            double dBaseAxisLen = bXDir ? (double)destBmp.Height : (double)destBmp.Width;//判断扭曲方式
            for (int i = 0; i < destBmp.Width; i++)
            {
                for (int j = 0; j < destBmp.Height; j++)
                {
                    double dx = 0;
                    dx = bXDir ? (PI2 * (double)j) / dBaseAxisLen : (PI2 * (double)i) / dBaseAxisLen;
                    dx += dPhase;
                    double dy = Math.Sin(dx);
                    // 取得当前点的颜色
                    int nOldX = 0, nOldY = 0;
                    nOldX = bXDir ? i + (int)(dy * dMultValue) : i;
                    nOldY = bXDir ? j : j + (int)(dy * dMultValue);
                    System.Drawing.Color color = srcBmp.GetPixel(i, j);
                    if (nOldX >= 0 && nOldX < destBmp.Width
                     && nOldY >= 0 && nOldY < destBmp.Height)
                    {
                        destBmp.SetPixel(nOldX, nOldY, color);
                    }
                }
            }
            return destBmp;
        }
        #endregion

        #endregion

        #endregion

        #region 2、生成随机字符串  2020.10.22
        public static string mrChineseChars = String.Empty;
        // 英文与数字串
        protected static readonly string mrEnglishOrNumChar = "0123456789";
        protected static readonly string mrEnglishOrNumCharc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        protected static readonly string mrEnglishOrNumCharcs = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        #region 对外调用公共方法
        /// <summary>
        /// 生成随机字符码：生成指定长度的包含指定数量随机验证码的字符码
        /// 手动输入字符串长度，能够产生纯数字、纯字母、纯文字、数字+字母、数字+文字、字母+文字、数字+字母+文字等类型字符串
        /// </summary>
        /// <param name="fb">区别数字、字母的验证码：-1：纯数字；0：纯字母；1：数字+字母</param>
        /// <param name="codeLen">验证码长度</param>
        /// <param name="zhCharsCount">所包含的汉子数量</param>
        /// <returns></returns>
        public string CreateVerifyCode(int fb, int codeLen, int zhCharsCount)
        {
            char[] chs = new char[codeLen];

            int index;
            for (int i = 0; i < zhCharsCount; i++)
            {
                index = rndNumber.Next(0, codeLen);
                if (chs[index] == '\0')
                    chs[index] = CreateZhChar();
                else
                    --i;
            }
            for (int i = 0; i < codeLen; i++)
            {
                if (chs[i] == '\0')
                {
                    switch (fb)
                    {
                        case -1:
                            chs[i] = mrEnglishOrNumChar[rndNumber.Next(0, mrEnglishOrNumChar.Length)];
                            break;
                        case 0:
                            chs[i] = mrEnglishOrNumCharc[rndNumber.Next(0, mrEnglishOrNumCharc.Length)];
                            break;
                        case 1:
                            chs[i] = mrEnglishOrNumCharcs[rndNumber.Next(0, mrEnglishOrNumCharcs.Length)];
                            break;
                    }
                }
            }
            return new string(chs, 0, chs.Length);
        }
        #endregion

        #region 生成随机字符码：辅助方法
        /// <summary>
        /// 生成汉字字符
        /// </summary>
        /// <returns></returns>
        protected char CreateZhChar()
        {
            //若提供了汉字集，查询汉字集选取汉字
            if (mrChineseChars.Length > 0)
            {
                return mrChineseChars[rndNumber.Next(0, mrChineseChars.Length)];
            }
            //若没有提供汉字集，则根据《GB2312简体中文编码表》编码规则构造汉字
            else
            {
                byte[] bytes = new byte[2];
                //第一个字节值在0xb0, 0xf7之间
                bytes[0] = (byte)rndNumber.Next(0xb0, 0xf8);
                //第二个字节值在0xa1, 0xfe之间
                bytes[1] = (byte)rndNumber.Next(0xa1, 0xff);
                //根据汉字编码的字节数组解码出中文汉字
                string str1 = Encoding.GetEncoding("gb2312").GetString(bytes);
                return str1[0];
            }
        }
        #endregion

        #endregion

        #region 3、图片压缩  2020.10.22

        #region 对外调用公共方法
        /// <summary>
        /// 压缩图片：传入图片Stream数据流和压缩图片的质量，返回图片byte[]数据；
        /// 图片质量等级：0L-100L等级，方法调用方式：CompressionImage([图片Stream流], 50L);
        /// </summary>
        /// <param name="fileStream">图片流</param>
        /// <param name="quality">压缩质量0L-100L之间 数值越大，质量越高</param>
        /// <returns></returns>
        public byte[] CompressionImage(Stream fileStream, long quality)
        {
            using (System.Drawing.Image img = System.Drawing.Image.FromStream(fileStream))
            {
                using (Bitmap bitmap = new Bitmap(img))
                {
                    ImageCodecInfo CodecInfo = GetEncoder(img.RawFormat);
                    System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                    EncoderParameters myEncoderParameters = new EncoderParameters(1);
                    EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, quality);
                    myEncoderParameters.Param[0] = myEncoderParameter;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bitmap.Save(ms, CodecInfo, myEncoderParameters);
                        myEncoderParameters.Dispose();
                        myEncoderParameter.Dispose();
                        return ms.ToArray();
                    }
                }
            }
        }
        #endregion

        #region 图片压缩辅助方法
        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                { return codec; }
            }
            return null;
        }
        #endregion

        #endregion

        #region 4、将 Byte[] 图片数据转换为图片并存储在文件中  2020.10.22
        /// <summary>
        /// 将 Byte[] 转换为图片并存储在文件中
        /// </summary>
        /// <param name="fileName">文件保存的路径及名称</param>
        /// <param name="buffer">byte[]格式图片数据</param>
        /// <returns></returns>
        public static string CreateImageFromBytes(string fileName, byte[] buffer)
        {
            string file = fileName;
            MemoryStream ms = new MemoryStream(buffer);
            Image image = System.Drawing.Image.FromStream(ms);
            ImageFormat format = image.RawFormat;
            if (format.Equals(ImageFormat.Jpeg))
            {
                file += ".jpeg";
            }
            else if (format.Equals(ImageFormat.Png))
            {
                file += ".png";
            }
            else if (format.Equals(ImageFormat.Bmp))
            {
                file += ".bmp";
            }
            else if (format.Equals(ImageFormat.Gif))
            {
                file += ".gif";
            }
            else if (format.Equals(ImageFormat.Icon))
            {
                file += ".icon";
            }
            System.IO.FileInfo info = new System.IO.FileInfo(file);
            System.IO.Directory.CreateDirectory(info.Directory.FullName);
            try
            {
                File.WriteAllBytes(file, buffer);
                return file;
            }
            catch (Exception)
            {
                return "false";
            }
        }
        #endregion

        #region 5、生成二维码图片  2020.10.22
        /// <summary>
        /// 输入字符串及二维码的尺寸，生成二维码图片
        /// 该方法需要引用ThoughtWorks.QRCode.dll
        /// </summary>
        /// <param name="codeStr">要生成二维码的字符串</param>
        /// <param name="size">二维码图片尺寸</param>
        /// <returns>二维码图片</returns>
        public static Image CreateImgQRCode(string codeStr, int size)
        {
            Bitmap _image = null;
            QRCodeEncoder _qrCodeEncoder = new QRCodeEncoder(); // 创建二维码生成类
            _qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE; // 设置编码模式
            _qrCodeEncoder.QRCodeScale = size; // 设置编码测量度
            _qrCodeEncoder.QRCodeVersion = 0; // 设置编码版本
            _qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M; // 设置编码错误纠正
            _image = _qrCodeEncoder.Encode(codeStr);
            return _image;
        }
        #endregion

        #region 6、生成一维码/条形码图片  2020.10.22
        /// <summary>
        /// 字符串生成一维码/条形码，
        /// </summary>
        /// <param name="content">生成条形码的字符串</param>
        /// <param name="widths">条形码宽度</param>
        /// <param name="heights">条形码高度</param>
        /// <param name="contYN">是否显示条形码的字符串</param>
        /// <returns>返回条形码图片数据</returns>
        public static Image CreateBarCode(string content, int widths, int heights, bool contYN)
        {
            using (var barcode = new Barcode()
            {
                //true显示content，false反之
                IncludeLabel = contYN,
                //content的位置
                Alignment = AlignmentPositions.CENTER,
                //条形码的宽高
                Width = widths,
                Height = heights,
                //类型
                RotateFlipType = RotateFlipType.RotateNoneFlipNone,
                //颜色
                BackColor = Color.White,
                ForeColor = Color.Black,
            })
            {
                try
                {
                    return barcode.Encode(TYPE.CODE128B, content);//条形码的类型
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        #endregion

        #region 7、合并用户QR图片和用户头像 2020.10.22

        #region 公共调用方法
        /// <summary>
        /// 合并用户QR图片和用户头像
        /// </summary>
        /// <param name="qrImg">QR图片</param>
        /// <param name="headerImg">用户头像</param>
        /// <returns>返回生成的图像的Bitmap数据</returns>
        public Bitmap MergeQrImg(Bitmap qrImg, Bitmap headerImg)
        {
            int margin = 10;
            float dpix = qrImg.HorizontalResolution;
            float dpiy = qrImg.VerticalResolution;
            var _newWidth = (10 * qrImg.Width - 36 * margin) * 1.0f / 36;
            var _headerImg = ZoomPic(headerImg, _newWidth / headerImg.Width);
            //处理头像
            int newImgWidth = _headerImg.Width + margin;
            Bitmap headerBgImg = new Bitmap(newImgWidth, newImgWidth);
            headerBgImg.MakeTransparent();
            Graphics g = Graphics.FromImage(headerBgImg);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.Transparent);
            Pen p = new Pen(new SolidBrush(Color.White));
            Rectangle rect = new Rectangle(0, 0, newImgWidth - 1, newImgWidth - 1);
            using (GraphicsPath path = CreateRoundedRectanglePath(rect, 1))
            {
                g.DrawPath(p, path);
                g.FillPath(new SolidBrush(Color.White), path);
            }
            //画头像
            Bitmap img1 = new Bitmap(_headerImg.Width, _headerImg.Width);
            Graphics g1 = Graphics.FromImage(img1);
            g1.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g1.SmoothingMode = SmoothingMode.HighQuality;
            g1.Clear(Color.Transparent);
            Pen p1 = new Pen(new SolidBrush(Color.Gray));
            Rectangle rect1 = new Rectangle(0, 0, _headerImg.Width - 1, _headerImg.Width - 1);
            using (GraphicsPath path1 = CreateRoundedRectanglePath(rect1, 1))
            {
                g1.DrawPath(p1, path1);
                TextureBrush brush = new TextureBrush(_headerImg);
                g1.FillPath(brush, path1);
            }
            g1.Dispose();
            PointF center = new PointF((newImgWidth - _headerImg.Width) / 2, (newImgWidth - _headerImg.Height) / 2);
            g.DrawImage(img1, center.X, center.Y, _headerImg.Width, _headerImg.Height);
            g.Dispose();
            Bitmap backgroudImg = new Bitmap(qrImg.Width, qrImg.Height);
            backgroudImg.MakeTransparent();
            backgroudImg.SetResolution(dpix, dpiy);
            headerBgImg.SetResolution(dpix, dpiy);
            Graphics g2 = Graphics.FromImage(backgroudImg);
            g2.Clear(Color.Transparent);
            g2.DrawImage(qrImg, 0, 0);
            PointF center2 = new PointF((qrImg.Width - headerBgImg.Width) / 2, (qrImg.Height - headerBgImg.Height) / 2);
            g2.DrawImage(headerBgImg, center2);
            g2.Dispose();
            return backgroudImg;
        }
        #endregion

        #region 辅助方法
        /// <summary>
        /// 创建圆角矩形
        /// </summary>
        /// <param name="rect">区域</param>
        /// <param name="cornerRadius">圆角角度</param>
        /// <returns></returns>
        private GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int cornerRadius)
        {
            //下午重新整理下，圆角矩形
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRect.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius * 2, rect.Y);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRect.AddLine(rect.Right, rect.Y + cornerRadius * 2, rect.Right, rect.Y + rect.Height - cornerRadius * 2);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y + rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            roundedRect.AddLine(rect.Right - cornerRadius * 2, rect.Bottom, rect.X + cornerRadius * 2, rect.Bottom);
            roundedRect.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.AddLine(rect.X, rect.Bottom - cornerRadius * 2, rect.X, rect.Y + cornerRadius * 2);
            roundedRect.CloseFigure();
            return roundedRect;
        }
        #endregion

        #endregion

        #region 8、在图片四周加入白边 2020.11.27
        /// <summary>
        /// 在图片四周加入白边
        /// </summary>
        /// <param name="Img">图片</param>
        /// <param name="Margin">白边的高度，单位是像素</param>
        /// <returns>Bitmap</returns>
        public static Bitmap ImageAddFrame(Image Img, int Margin)
        {
            //位图宽高
            int width = Img.Width + Margin;
            int height = Img.Height + Margin;
            Bitmap BitmapResult = new Bitmap(width, height);
            Graphics Grp = Graphics.FromImage(BitmapResult);
            SolidBrush b = new SolidBrush(Color.White);//这里修改颜色
            Grp.FillRectangle(b, 0, 0, width, height);
            System.Drawing.Rectangle Rec = new System.Drawing.Rectangle(0, 0, Img.Width, Img.Height);
            //向矩形框内填充Img
            Grp.DrawImage(Img, Margin / 2, Margin / 2, Rec, GraphicsUnit.Pixel);
            //返回位图文件
            Grp.Dispose();
            GC.Collect();
            return BitmapResult;
        }
        #endregion

        #region 9、图片按比例缩放尺寸  2020.10.22
        /// <summary>
        /// 图片按比例缩放尺寸
        /// </summary>
        /// <param name="initImage">图片文件</param>
        /// <param name="n">缩放比例</param>
        /// <returns>返回的缩小图片数据</returns>
        public Image ZoomPic(Image initImage, double n)
        {
            //缩略图宽、高计算
            double newWidth = initImage.Width;
            double newHeight = initImage.Height;
            newWidth = n * initImage.Width;
            newHeight = n * initImage.Height;
            //生成新图
            //新建一个bmp图片
            Image newImage = new Bitmap((int)newWidth, (int)newHeight);
            //新建一个画板
            Graphics newG = Graphics.FromImage(newImage);
            //设置质量
            newG.InterpolationMode = InterpolationMode.HighQualityBicubic;
            newG.SmoothingMode = SmoothingMode.HighQuality;
            //置背景色
            newG.Clear(Color.Transparent);
            //画图
            newG.DrawImage(initImage, new Rectangle(0, 0, newImage.Width, newImage.Height), new Rectangle(0, 0, initImage.Width, initImage.Height), GraphicsUnit.Pixel);
            newG.Dispose();
            return newImage;
        }
        #endregion

        #region 10、将Bitmap格式图片按照指定长宽生成缩略图  2020.10.22
        /// <summary>
        /// 创建缩略图
        /// </summary>
        /// <param name="imgs">Bitmap格式的图片数据</param>
        /// <param name="destHeight">高度分辨率</param>
        /// <param name="destWidth">宽度分辨率</param>
        /// <returns>返回缩略图的Bitmap格式数据</returns>
        public static Bitmap GetThumbnail(Bitmap imgs, int destHeight, int destWidth)
        {
            Image imgSource = imgs;
            ImageFormat thisFormat = imgSource.RawFormat;
            int sW = 0, sH = 0;
            // 按比例缩放 
            int sWidth = imgSource.Width;
            int sHeight = imgSource.Height;
            if (sHeight > destHeight || sWidth > destWidth)
            {
                if ((sWidth * destHeight) > (sHeight * destWidth))
                {
                    sW = destWidth;
                    sH = (destWidth * sHeight) / sWidth;
                }
                else
                {
                    sH = destHeight;
                    sW = (sWidth * destHeight) / sHeight;
                }
            }
            else
            {
                sW = sWidth;
                sH = sHeight;
            }
            Bitmap outBmp = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage(outBmp);
            g.Clear(Color.Transparent);
            // 设置画布的描绘质量 
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(imgSource, new Rectangle((destWidth - sW) / 2, (destHeight - sH) / 2, sW, sH), 0, 0, imgSource.Width, imgSource.Height, GraphicsUnit.Pixel);
            g.Dispose();
            // 以下代码为保存图片时，设置压缩质量 
            EncoderParameters encoderParams = new EncoderParameters();
            long[] quality = new long[1];
            quality[0] = 100;
            EncoderParameter encoderParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            encoderParams.Param[0] = encoderParam;
            imgSource.Dispose();
            return outBmp;
        }
        #endregion

        #region 11、将字符串按照置顶的长度分段成字符串数组  2020.10.27

        #region 公共调用方法
        /// <summary>
        /// 将字符串按照置顶的长度分段成字符串数组
        /// </summary>
        /// <param name="str">指定字符串</param>
        /// <param name="len">截取长度</param>
        /// <returns>返回字符串数组</returns>
        public static string[] getSubString(string str, int len)
        {
            return getStrs(str, len).Split('\t');
        }
        #endregion

        #region 辅助方法
        private static string getStrs(string str, int len)
        {
            if (str.Length < len) return str;
            string strs = "";
            string strmini = str.Substring(0, len);
            string strsy = str.Substring(len, str.Length - strmini.Length);
            string gets = getStrs(strsy, len);
            if (gets.Equals(""))
            {
                strs += strmini;
            }
            else
            {
                strs += strmini + "\t" + gets;
            }
            return strs;
        }
        #endregion

        #endregion

        #region 12、程序中调用CMD.exe程序，并且不显示命令行窗口界面  2020.10.29
        /// <summary>  
        /// 程序中调用CMD.exe程序，并且不显示命令行窗口界面  
        /// </summary>  
        /// <param name="c">执行的cmd命令</param>  
        public static void Cmd(string c)
        {
            try
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动  
                p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息  
                p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息  
                p.StartInfo.RedirectStandardError = true;//重定向标准错误输出  
                p.StartInfo.CreateNoWindow = true;//不显示程序窗口  
                p.Start();//启动程序  
                //向cmd窗口发送输入信息  
                p.StandardInput.WriteLine(c + "&exit");
                p.StandardInput.AutoFlush = true;
                //获取cmd窗口的输出信息  
                string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();//等待程序执行完退出进程  
                p.Close();

            }
            catch { }
        }
        #endregion

        #region 13、获取四种格式的GUID字符串  2020.10.29
        /// <summary>
        /// 获取四种格式的GUID字符串：格式类别：默认、N、D、B、P、X
        /// </summary>
        /// <param name="styp">格式类别</param>
        /// <returns>返回GUID字符串</returns>
        public static string getNewGUID(string styp)
        {
            string guid = "";
            switch (styp)
            {
                case "": guid = Guid.NewGuid().ToString(); break;// 9af7f46a-ea52-4aa3-b8c3-9fd484c2af12
                case "N": guid = Guid.NewGuid().ToString("N"); break;// e0a953c3ee6040eaa9fae2b667060e09
                case "D": guid = Guid.NewGuid().ToString("D"); break;// 9af7f46a-ea52-4aa3-b8c3-9fd484c2af12
                case "B": guid = Guid.NewGuid().ToString("B"); break;// {734fd453-a4f8-4c5d-9c98-3fe2d7079760}
                case "P": guid = Guid.NewGuid().ToString("P"); break;//  (ade24d16-db0f-40af-8794-1e08e2040df3)
                case "X": guid = Guid.NewGuid().ToString("X"); break;// {0x3fa412e3,0x8356,0x428f,{0xaa,0x34,0xb7,0x40,0xda,0xaf,0x45,0x6f}}
            }
            return guid;
        }
        #endregion

        #region 14、获取计算机硬件的唯一标识    2021.10.17
        public static string GetCPUUID()
        {
            string code = null;
            SelectQuery query = new SelectQuery("select * from Win32_ComputerSystemProduct");
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                foreach (var item in searcher.Get())
                {
                    using (item) code = item["UUID"].ToString();
                }
            }
            return code;
        }
        #endregion
        
        #region MD5加密
        /// <summary>     
        /// MD5加密     
        /// </summary>     
        /// <param name="strSource">需要加密的字符串</param>     
        /// <returns>MD5加密后的字符串</returns>     
        public static string Md5Encrypt(string strSource)
        {
            //把字符串放到byte数组中     
            byte[] bytIn = System.Text.Encoding.Default.GetBytes(strSource);
            //建立加密对象的密钥和偏移量             
            byte[] iv = { 102, 16, 93, 156, 78, 4, 218, 32 };//定义偏移量     
            byte[] key = { 55, 103, 246, 79, 36, 99, 167, 3 };//定义密钥     
            //实例DES加密类     
            DESCryptoServiceProvider mobjCryptoService = new DESCryptoServiceProvider();
            mobjCryptoService.Key = iv;
            mobjCryptoService.IV = key;
            ICryptoTransform encrypto = mobjCryptoService.CreateEncryptor();
            //实例MemoryStream流加密密文件     
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Write);
            cs.Write(bytIn, 0, bytIn.Length);
            cs.FlushFinalBlock();
            return System.Convert.ToBase64String(ms.ToArray());
        }
        #endregion


        #region MD5解密
        /// <summary>     
        /// MD5解密     
        /// </summary>     
        /// <param name="Source">需要解密的字符串</param>     
        /// <returns>MD5解密后的字符串</returns>     
        public static string Md5Decrypt(string Source)
        {
            //将解密字符串转换成字节数组     
            byte[] bytIn = System.Convert.FromBase64String(Source);
            //给出解密的密钥和偏移量，密钥和偏移量必须与加密时的密钥和偏移量相同     
            byte[] iv = { 102, 16, 93, 156, 78, 4, 218, 32 };//定义偏移量     
            byte[] key = { 55, 103, 246, 79, 36, 99, 167, 3 };//定义密钥     
            DESCryptoServiceProvider mobjCryptoService = new DESCryptoServiceProvider();
            mobjCryptoService.Key = iv;
            mobjCryptoService.IV = key;
            //实例流进行解密     
            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytIn, 0, bytIn.Length);
            ICryptoTransform encrypto = mobjCryptoService.CreateDecryptor();
            CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Read);
            StreamReader strd = new StreamReader(cs, Encoding.Default);
            return strd.ReadToEnd();
        }
        #endregion

        #endregion
    }
}