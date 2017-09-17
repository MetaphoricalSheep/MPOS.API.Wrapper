# MPOS API Wrapper in C#

MPOS API Wrapper in C#

The MPOS API documentation can be viewed on (https://github.com/MPOS/php-mpos/wiki/API-Reference)

I used https://suprnova.cc to build this wrapper. Drop me a message if it doesn't play well with your pool so that I can update the code.


## Getting Started

### Installation

You can clone the repository to any path.  

```bash
git clone https://github.com/MetaphoricalSheep/MPOS.API.Wrapper.git
```

### Usage  

All the MPOS API methods are exposed through the ```Client``` class. Instantiate an instance of the client to get started.  

```c#
using MetaphoricalSheep.MPOS.API;

using (var client = new Client("https://zen.suprnova.cc")
{
    var response = client.GetUserBalance();
    Console.WriteLine($"Confirmed: {response.Response.Data.Confirmed}");
    Console.WriteLine($"Unconfirmed: {response.Response.Data.Unconfirmed}");
    Console.WriteLine($"Orphaned: {response.Response.Data.Orphaned}");
}
```

## Donations

| Icon | Currency         | Address |
+------+------------------+---------+
| AEON | Aeon             | WmtDo9qNHyECGZytcr4iHmiEoZcu9VrY2BkGhPxMcXtZFjHsfRyycY9FzRFU9Qq1Xa12kEwjk8ov8RPbfP4ZpezW1x37VhUxv |
| BCC  | Bitcoin Cash     | 1CJNaX3AGrxMNCzeCMeD2vrmM6gDLZvWYH |
| BCN  | ByteCoin         | 28rW2bgiiExfrLfxzRPyfqTxAKE7ihRz9SwBVtVkXgvW4TNEJRgTbnNdi7ok6B5SQT6UXUtQgusruCoXbqUZm8VJAgFHuXZ |
| BTC  | Bitcoin          | 1GUDpkhbNS5oy3Pujypkp6WEK5qzH2ZaPQ |
| DASH | Dash             | Xn28ycb8xAXR8QiTSCN4a8chDCJwmQBDBw |
| ETC  | Ethereum Classic | 0xa3f6DB80B90992742623389863Bf676a2D399464 |
| ETH  | Ethereum         | 0xa3f6DB80B90992742623389863Bf676a2D399464 |
| FTC  | FeatherCoin      | 6vxupqtBPCj9NsbVJXbTEm6PiUyfyT1Tia |
| HODL | HOdlcoin         | HP5CrYSidkzq9MoiwBys2hdR8gAvwf4QUP |
| HUSH | Hush             | t1XUDPdtxmA5sZ9zv4tBDfQYxjGA3dL4LRH |
| KMD  | Komodo           | RPw2Y93EbEyPqnJ2yzicg1oSqdpJgG6R2w |
| LTC  | Litecoin         | LUtUedt77smoQY41EQpLTMVyCT1b7jfxtg |
| NEO  | Neo              | AMe2ANUpvDNRvD6dwsVer6gA7BhVWU5T3i |
| MONA | MonaCoin         | MLg6a9Wz425hZnQzkG7zfRYDahQf4uiuCH |
| PXC  | PhoenixCoin      | PtQNTXMArpRxyr7zyy1Y2E9rF8xt9MupxU |
| SIB  | SibCoin          | SNRZN8yeCu9H5B9PHg4BkabvgrEccW4Fic |
| SIGT | Signatum         | BRVeccRjMJDk6o5uXfUobid5YQnm8hF2SM |
| VTC  | VertCoin         | Vnyt9mMkqMU2h3PnXrzRGK6nDzYDtzpLkZ |
| ZCL  | ZClassic         | t1L4apT5MTSTEvvd3ZqdaxXAkGMxkz456Dh |
| ZEC  | ZCash            | t1aYfJaGTCEGnUnrR6vGKVdWRrWqbPo9rci |
| ZEN  | ZenCash          | znjNkCXXEN84epeoYaANWovzwRcqsKphzvt |

## License

Copyright (c) 2017 - Metaphorical Sheep

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
