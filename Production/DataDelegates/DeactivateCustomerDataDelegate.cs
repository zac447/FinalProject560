using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class DeactivateCustomerDataDelegate(int customerId)
       : DataDelegate("Deactivate_Customer")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@CustomerID", customerId);
        }
    }
}
