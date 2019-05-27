using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReportService
{
    class Feedback
    {
        string customerFeedback;
        int rateFeedback;

        public Feedback(string CutomerFeedback, int RateFeedback)
        {
            this.customerFeedback = CutomerFeedback;
            this.rateFeedback = RateFeedback;
        }

        
        public string ChangeYourFeedback(string ChangedCustomerFeedback)
        {
            this.customerFeedback = ChangedCustomerFeedback;
        }

        public int ChangeYourRankedFeedback(int ChangedrateFeedback)
        {
           this.rateFeedback = ChangedrateFeedback; 
        }
    }
}
