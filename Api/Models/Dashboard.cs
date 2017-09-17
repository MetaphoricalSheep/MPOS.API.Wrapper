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


using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MetaphoricalSheep.Mpos.Api.Models
{
    [DataContract]
    public class Dashboard
    {
        [DataMember(Name = "raw")]
        public Raw Raw { get; set; }

        [DataMember(Name = "personal")]
        public Personal Personal { get; set; }

        [DataMember(Name = "pool")]
        public Pool Pool { get; set; }

        [DataMember(Name = "system")]
        public DashSystem System { get; set; }

        [DataMember(Name = "network")]
        public Network Network { get; set; }
    }

    [DataContract]
    public class Raw
    {
        [DataMember(Name = "personal")]
        public InternalHashrate Personal { get; set; }

        [DataMember(Name = "pool")]
        public InternalHashrate Pool { get; set; }

        [DataMember(Name = "network")]
        public RawNetwork Network { get; set; }
    }

    [DataContract]
    public class RawNetwork
    {
        [DataMember(Name = "hashrate")]
        public long Hashrate { get; set; }

        [DataMember(Name = "esttimeperblock")]
        public double EstimatedTimePerBlock { get; set; }

        [DataMember(Name = "nextdifficulty")]
        public double NextDifficulty { get; set; }

        [DataMember(Name = "blocksuntildiffchange")]
        public int BlocksUntilDifficultyChange { get; set; }
    }

    [DataContract]
    public class Personal
    {
        [DataMember(Name = "hashrate")]
        public double Hashrate { get; set; }

        [DataMember(Name = "sharerate")]
        public double ShareRate { get; set; }

        [DataMember(Name = "sharedifficulty")]
        public double ShareDifficulty { get; set; }

        [DataMember(Name = "shares")]
        public PersonalShares Shares { get; set; }

        [DataMember(Name = "estimates")]
        public Estimates Estimates { get; set; }
    }

    [DataContract]
    public abstract class Shares
    {
        [DataMember(Name = "valid")]
        public double Valid { get; set; }

        [DataMember(Name = "invalid")]
        public double Invalid { get; set; }

        [DataMember(Name = "invalid_percent")]
        public double InvalidPercent { get; set; }
    }

    [DataContract]
    public class PersonalShares : Shares
    {
        [DataMember(Name = "unpaid")]
        public double Unpaid { get; set; }
    }

    [DataContract]
    public class Estimates
    {
        [DataMember(Name = "block")]
        public double Block { get; set; }

        [DataMember(Name = "fee")]
        public double Fee { get; set; }

        [DataMember(Name = "donation")]
        public double Donation { get; set; }

        [DataMember(Name = "payout")]
        public double Payout { get; set; }
    }

    [DataContract]
    public class Pool
    {
        [DataMember(Name = "info")]
        public DashPoolInfo Info { get; set; }

        [DataMember(Name = "esttimeperblock")]
        public double EstimatedTimePerBlock { get; set; }

        [DataMember(Name = "blocks")]
        public List<Block> Blocks { get; set; }

        [DataMember(Name = "workers")]
        public int Workers { get; set; }

        [DataMember(Name = "hashrate")]
        public double Hashrate { get; set; }

        [DataMember(Name = "shares")]
        public PoolShares Shares { get; set; }

        [DataMember(Name = "price")]
        public string Price { get; set; }

        [DataMember(Name = "difficulty")]
        public int Difficulty { get; set; }

        [DataMember(Name = "target_bits")]
        public int TargetBits { get; set; }
    }

    [DataContract]
    public class DashPoolInfo
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }
    }

    [DataContract]
    public class PoolShares : Shares
    {
        [DataMember(Name = "estimated")]
        public int Estimated { get; set; }

        [DataMember(Name = "progress")]
        public double Progress { get; set; }
    }

    [DataContract]
    public class DashSystem
    {
        [DataMember(Name = "load")]
        public List<double> Load { get; set; }
    }

    [DataContract]
    public class Network
    {
        [DataMember(Name = "hashrate")]
        public long Hashrate { get; set; }

        [DataMember(Name = "difficulty")]
        public double Difficulty { get; set; }

        [DataMember(Name = "block")]
        public long Block { get; set; }

        [DataMember(Name = "esttimeperblock")]
        public double EstimatedTimePerBlock { get; set; }

        [DataMember(Name = "nextdifficulty")]
        public double NextDifficulty { get; set; }

        [DataMember(Name = "blocksuntildiffchange")]
        public int BlocksUntilDifficultyChange { get; set; }
    }
}