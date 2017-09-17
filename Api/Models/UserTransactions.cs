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


using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MetaphoricalSheep.Mpos.Api.Models
{
    [DataContract]
    public class UserTransactions
    {
        [DataMember(Name = "transactions")]
        public List<Transaction> Transactions { get; set; }
    }

    [DataContract]
    public class Transaction
    {
        [DataMember(Name = "id")]
        public long Id { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "amount")]
        public double Amount { get; set; }

        [DataMember(Name = "coin_address")]
        public string CoinAddress { get; set; }

        [DataMember(Name = "timestamp")]
        public DateTime Timestamp { get; set; }

        [DataMember(Name = "txid")]
        public string TransferId { get; set; }

        [DataMember(Name = "height")]
        public long Height { get; set; }

        [DataMember(Name = "blockhash")]
        public string BlockHash { get; set; }

        [DataMember(Name = "confirmations")]
        public int Confirmations { get; set; }
    }
}