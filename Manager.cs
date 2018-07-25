using System;

namespace interfacepractice
{
    public class Manager : Employee, IReviewer
    {
        public String Duty;
        public String Approve()
        {
            return ($"Timesheet approved by {this.firstname} {this.lastname}\n");
        }
        public String Reject()
        {  
            String reasonForRejection = ($"There was an error in your timesheet, rejected by {this.firstname} {this.lastname}\n");
            return reasonForRejection;
        }
    }
}
