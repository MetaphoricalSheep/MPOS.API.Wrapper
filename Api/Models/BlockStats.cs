/**********************************************************************************************************************************
 * Copyright (c) 2017 - Metaphorical Sheep
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */


using System.Runtime.Serialization;

namespace MetaphoricalSheep.Mpos.Api.Models
{
    [DataContract]
    public class BlockStats
    {
        public BlockTotal Total { get; set; } = new BlockTotal();
        public BlockTotal Hour { get; set; } = new BlockTotal();
        public BlockTotal Day { get; set; } = new BlockTotal();
        public BlockTotal Week { get; set; } = new BlockTotal();
        public BlockTotal Month { get; set; } = new BlockTotal();
        public BlockTotal Year { get; set; } = new BlockTotal();

        [DataMember(Name = "Total")]
        protected string DataTotal
        {
            set => Total.Total = value;
        }

        [DataMember(Name = "TotalValid")]
        protected string DataTotalValid
        {
            set => Total.Valid = value;
        }

        [DataMember(Name = "TotalOrphan")]
        protected string DataTotalOrphan
        {
            set => Total.Orphan = value;
        }

        [DataMember(Name = "TotalDifficulty")]
        protected long DataTotalDifficulty
        {
            set => Total.Difficulty = value;
        }

        [DataMember(Name = "TotalShares")]
        protected string DataTotalShares
        {
            set => Total.Shares = value;
        }

        [DataMember(Name = "TotalAmount")]
        protected double DataTotalAmount
        {
            set => Total.Amount = value;
        }

        [DataMember(Name = "1HourTotal")]
        protected string DataHourTotal
        {
            set => Hour.Total = value;
        }

        [DataMember(Name = "1HourValid")]
        protected string DataHourValid
        {
            set => Hour.Valid = value;
        }

        [DataMember(Name = "1HourOrphan")]
        protected string DataHourOrphan
        {
            set => Hour.Orphan = value;
        }

        [DataMember(Name = "1HourDifficulty")]
        protected double DataHourDifficulty
        {
            set => Hour.Difficulty = value;
        }

        [DataMember(Name = "1HourShares")]
        protected string DataHourShares
        {
            set => Hour.Shares = value;
        }

        [DataMember(Name = "1HourAmount")]
        protected double DataHourAmount
        {
            set => Hour.Amount = value;
        }

        [DataMember(Name = "24HourTotal")]
        protected string DataDayTotal
        {
            set => Day.Total = value;
        }

        [DataMember(Name = "24HourValid")]
        protected string DataDayValid
        {
            set => Day.Valid = value;
        }

        [DataMember(Name = "24HourOrphan")]
        protected string DataDayOrphan
        {
            set => Day.Orphan = value;
        }

        [DataMember(Name = "24HourDifficulty")]
        protected double DataDayDifficulty
        {
            set => Day.Difficulty = value;
        }

        [DataMember(Name = "24HourShares")]
        protected string DataDayShares
        {
            set => Day.Shares = value;
        }

        [DataMember(Name = "24HourAmount")]
        protected double DataDayAmount
        {
            set => Day.Amount = value;
        }

        [DataMember(Name = "7DaysTotal")]
        protected string DataWeekTotal
        {
            set => Week.Total = value;
        }

        [DataMember(Name = "7DaysValid")]
        protected string DataWeekValid
        {
            set => Week.Valid = value;
        }

        [DataMember(Name = "7DaysOrphan")]
        protected string DataWeekOrphan
        {
            set => Week.Orphan = value;
        }

        [DataMember(Name = "7DaysDifficulty")]
        protected double DataWeekDifficulty
        {
            set => Week.Difficulty = value;
        }

        [DataMember(Name = "7DaysShares")]
        protected string DataWeekShares
        {
            set => Week.Shares = value;
        }

        [DataMember(Name = "7DaysAmount")]
        protected double DataWeekAmount
        {
            set => Week.Amount = value;
        }

        [DataMember(Name = "4WeeksTotal")]
        protected string DataMonthTotal
        {
            set => Month.Total = value;
        }

        [DataMember(Name = "4WeeksValid")]
        protected string DataMonthValid
        {
            set => Month.Valid = value;
        }

        [DataMember(Name = "4WeeksOrphan")]
        protected string DataMonthOrphan
        {
            set => Month.Orphan = value;
        }

        [DataMember(Name = "4WeeksDifficulty")]
        protected double DataMonthDifficulty
        {
            set => Month.Difficulty = value;
        }

        [DataMember(Name = "4WeeksShares")]
        protected string DataMonthShares
        {
            set => Month.Shares = value;
        }

        [DataMember(Name = "4WeeksAmount")]
        protected double DataMonthAmount
        {
            set => Month.Amount = value;
        }

        [DataMember(Name = "12MonthTotal")]
        protected string DataYearTotal
        {
            set => Year.Total = value;
        }

        [DataMember(Name = "12MonthValid")]
        protected string DataYearValid
        {
            set => Year.Valid = value;
        }

        [DataMember(Name = "12MonthOrphan")]
        protected string DataYearOrphan
        {
            set => Year.Orphan = value;
        }

        [DataMember(Name = "12MonthDifficulty")]
        protected double DataYearDifficulty
        {
            set => Year.Difficulty = value;
        }

        [DataMember(Name = "12MonthShares")]
        protected string DataYearShares
        {
            set => Year.Shares = value;
        }

        [DataMember(Name = "12MonthAmount")]
        protected double DataYearAmount
        {
            set => Year.Amount = value;
        }

        [DataMember(Name = "TotalEstimatedShares")]
        protected long DataTotalEstimatedShares
        {
            set => Total.EstimatedShares = value;
        }

        [DataMember(Name = "1HourEstimatedShares")]
        protected long DataHourEstimatedShares
        {
            set => Hour.EstimatedShares = value;
        }

        [DataMember(Name = "24HourEstimatedShares")]
        protected long DataDayEstimatedShares
        {
            set => Day.EstimatedShares = value;
        }

        [DataMember(Name = "7DaysEstimatedShares")]
        protected long DataWeekEstimatedShares
        {
            set => Week.EstimatedShares = value;
        }

        [DataMember(Name = "4WeeksEstimatedShares")]
        protected long DataMonthEstimatedShares
        {
            set => Month.EstimatedShares = value;
        }

        [DataMember(Name = "12MonthEstimatedShares")]
        protected long DataYearEstimatedShares
        {
            set => Year.EstimatedShares = value;
        }
    }

    public class BlockTotal
    {
        public string Total { get; set; }
        public string Valid { get; set; }
        public string Orphan { get; set; }
        public double Difficulty { get; set; }
        public string Shares { get; set; }
        public double Amount { get; set; }
        public long EstimatedShares { get; set; }
    }
}