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
    public class NavbarData
    {
        [DataMember(Name = "raw")]
        public NavRaw Raw { get; set; }

        [DataMember(Name = "pool")]
        public NavPool Pool { get; set; }

        [DataMember(Name = "network")]
        public NavNetwork Network { get; set; }
    }

    [DataContract]
    public class NavRaw
    {
        [DataMember(Name = "workers")]
        public int Workers { get; set; }

        [DataMember(Name = "pool")]
        public InternalHashrate Pool { get; set; }
    }

    [DataContract]
    public class NavPool
    {
        [DataMember(Name = "workers")]
        public int Workers { get; set; }

        [DataMember(Name = "hashrate")]
        public double Hashrate { get; set; }

        [DataMember(Name = "estimated")]
        public long Estimated { get; set; }

        [DataMember(Name = "progress")]
        public double Progress { get; set; }
    }

    [DataContract]
    public class NavNetwork
    {
        [DataMember(Name = "hashrate")]
        public double Hashrate { get; set; }

        [DataMember(Name = "difficulty")]
        public double Difficulty { get; set; }

        [DataMember(Name = "block")]
        public long Block { get; set; }
    }
}