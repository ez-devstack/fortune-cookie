using System;
using System.Collections.Generic;

/* 
    This model is for future use on automatic fortune creation from ChatGPT api every time 
    new Bitcoin block is mined and added to the blockchain. Fortunes will be stored in the
    BTCPay server plugin db for this plugin.
 */

 namespace BTCPayServer.Plugins.FortuneCookie.FortuneModel
{
    public class FortuneModel
    {
        public string FortuneId { get; set; }
        public string Fortune { get; set; }
        public string FortuneBlockHeight { get; set; }
    }
}