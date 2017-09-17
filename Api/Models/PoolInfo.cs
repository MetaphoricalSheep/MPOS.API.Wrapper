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
    public class PoolInfo
    {
        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "coinname")]
        public string CoinName { get; set; }

        [DataMember(Name = "cointarget")]
        public string CoinTarget { get; set; }

        [DataMember(Name = "coindiffchangetarget")]
        public int CoinDifficultyChangeTarget { get; set; }

        [DataMember(Name = "algorithm")]
        public string Algorithm { get; set; }

        [DataMember(Name = "stratumport")]
        public string StratumPort { get; set; }

        [DataMember(Name = "payout_system")]
        public string PayoutSystem { get; set; }

        [DataMember(Name = "confirmations")]
        public int Confirmations { get; set; }

        [DataMember(Name = "min_ap_threshold")]
        public double MinAutoPayoutThreshold { get; set; }

        [DataMember(Name = "max_ap_threshold")]
        public double MaxAutoPayoutThreshold { get; set; }

        [DataMember(Name = "reward_type")]
        public string RewardType { get; set; }

        [DataMember(Name = "reward")]
        public double Reward { get; set; }

        [DataMember(Name = "txfee")]
        public double TransferFee { get; set; }

        [DataMember(Name = "txfee_manual")]
        public double ManualTranferFee { get; set; }

        [DataMember(Name = "txfee_auto")]
        public double AutoTransferFee { get; set; }

        [DataMember(Name = "fees")]
        public double Fees { get; set; }
    }
}