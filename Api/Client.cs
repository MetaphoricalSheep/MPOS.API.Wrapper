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
using System.IO;
using System.Net;
using System.Text;
using MetaphoricalSheep.Mpos.Api.Responses;
using Newtonsoft.Json;

namespace MetaphoricalSheep.Mpos.Api
{
    public class Client : IDisposable
    {
        public string ApiKey { get; set; }
        protected string BaseUrl { get; set; }
        public int Timeout { get; set; }

        public Client(string baseUrl, int timeout=5000)
        {
            BaseUrl = $"{baseUrl}/index.php?page=api";
            Timeout = timeout;
        }

        public Client(string baseUrl, string apiKey, int timeout=5000)
        {
            ApiKey = apiKey;
            BaseUrl = $"{baseUrl}/index.php?page=api";
            Timeout = timeout;
        }

        protected T MakeRequest<T>(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new Exception("Url is empty.");
            }

            string json;

            try
            {
                var webRequest = (HttpWebRequest) WebRequest.Create(url);
                webRequest.ContentType = "application/json";
                webRequest.KeepAlive = false;
                webRequest.Method = "GET";
                webRequest.Timeout = Timeout;

                using (var webResponse = webRequest.GetResponse())
                {
                    using (var responseStream = webResponse.GetResponseStream())
                    {
                        if (responseStream == null)
                        {
                            throw new Exception("Response is empty.");
                        }

                        using (var responseReader = new StreamReader(responseStream, Encoding.UTF8))
                        {
                            json = responseReader.ReadToEnd();
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                switch (ex.Status)
                {
                    case WebExceptionStatus.Timeout:
                        throw new Exception("Request timed out.");
                    case WebExceptionStatus.ProtocolError:
                        var response = (HttpWebResponse) ex.Response;
                        switch (response.StatusCode)
                        {
                            case HttpStatusCode.NotFound:
                                throw new WebException("404 - Url not found.");
                            case HttpStatusCode.Unauthorized:
                                throw new WebException("401 - Supplied api key does not have access to this request.");
                            case HttpStatusCode.InternalServerError:
                                throw new WebException("500 - Internal server error. Please try again later.");
                            default:
                                throw new Exception($"{response.StatusCode} - {ex.Message}");
                        }
                    default:
                        throw new WebException("Something went wrong. " + ex.Message);
                }
            }
            catch (NotSupportedException)
            {
                throw new NotSupportedException("The url is malformed.");
            }

            return JsonConvert.DeserializeObject<T>(json);
        }

        protected void ValidateApiKey()
        {
            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new Exception("Api key is empty.");
            }
        }

        public Public Public()
        {
            var url = $"{BaseUrl}&action={Actions.Public}";
            return MakeRequest<Public>(url);
        }

        public GetBlockCountResponse GetBlockCount()
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetBlockCount}&api_key={ApiKey}";
            return MakeRequest<GetBlockCountResponse>(url);
        }

        public GetBlocksFoundResponse GetBlocksFound()
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetBlocksFound}&api_key={ApiKey}";
            return MakeRequest<GetBlocksFoundResponse>(url);
        }

        public GetBlockStatsResponse GetBlockStats()
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetBlockStats}&api_key={ApiKey}";
            return MakeRequest<GetBlockStatsResponse>(url);
        }

        public GetCurrentWorkersResponse GetCurrentWorkers()
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetCurrentWorkers}&api_key={ApiKey}";
            return MakeRequest<GetCurrentWorkersResponse>(url);
        }

        public GetDashboardDataResponse GetDashboardData()
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetDashboardData}&api_key={ApiKey}";
            return MakeRequest<GetDashboardDataResponse>(url);
        }

        public GetDifficultyResponse GetDifficulty()
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetDifficulty}&api_key={ApiKey}";
            return MakeRequest<GetDifficultyResponse>(url);
        }

        public GetEstimatedTimeResponse GetEstimatedTime()
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetEstimatedTime}&api_key={ApiKey}";
            return MakeRequest<GetEstimatedTimeResponse>(url);
        }

        public GetHourlyHashratesResponse GetHourlyHashrates()
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetHourlyHashrates}&api_key={ApiKey}";
            return MakeRequest<GetHourlyHashratesResponse>(url);
        }

        public GetNavbarDataResponse GetNavbarData()
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetNavbarData}&api_key={ApiKey}";
            return MakeRequest<GetNavbarDataResponse>(url);
        }

        public GetPoolHashrateResponse GetPoolHashrate()
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetPoolHashrate}&api_key={ApiKey}";
            return MakeRequest<GetPoolHashrateResponse>(url);
        }

        public GetPoolInfoResponse GetPoolInfo()
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetPoolInfo}&api_key={ApiKey}";
            return MakeRequest<GetPoolInfoResponse>(url);
        }

        public GetPoolShareRateResponse GetPoolShareRate()
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetPoolShareRate}&api_key={ApiKey}";
            return MakeRequest<GetPoolShareRateResponse>(url);
        }

        public GetPoolStatusResponse GetPoolStatus()
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetPoolStatus}&api_key={ApiKey}";
            return MakeRequest<GetPoolStatusResponse>(url);
        }

        public GetTimeSinceLastBlockResponse GetTimeSinceLastBlock()
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetTimeSinceLastBlock}&api_key={ApiKey}";
            return MakeRequest<GetTimeSinceLastBlockResponse>(url);
        }

        public GetTopContributorsResponse GetTopContributors()
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetTopContributors}&api_key={ApiKey}";
            return MakeRequest<GetTopContributorsResponse>(url);
        }

        public GetUserBalanceResponse GetUserBalance(int? id=null)
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetUserBalance}&api_key={ApiKey}&id={id}";
            return MakeRequest<GetUserBalanceResponse>(url);
        }

        public GetUserHashrateResponse GetUserHashrate(int? id=null)
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetUserHashrate}&api_key={ApiKey}&id={id}";
            return MakeRequest<GetUserHashrateResponse>(url);
        }

        public GetUserShareRateResponse GetUserShareRate(int? id=null)
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetUserShareRate}&api_key={ApiKey}&id={id}";
            return MakeRequest<GetUserShareRateResponse>(url);
        }

        public GetUserStatusResponse GetUserStatus(int? id=null)
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetUserStatus}&api_key={ApiKey}&id={id}";
            return MakeRequest<GetUserStatusResponse>(url);
        }

        public GetUserTransactionsResponse GetUserTransactions(int? id=null)
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetUserTransactions}&api_key={ApiKey}&id={id}";
            return MakeRequest<GetUserTransactionsResponse>(url);
        }

        public GetUserWorkersResponse GetUserWorkers(int? id=null)
        {
            ValidateApiKey();
            var url = $"{BaseUrl}&action={Actions.GetUserWorkers}&api_key={ApiKey}&id={id}";
            return MakeRequest<GetUserWorkersResponse>(url);
        }

        public void Dispose() { }
    }
}