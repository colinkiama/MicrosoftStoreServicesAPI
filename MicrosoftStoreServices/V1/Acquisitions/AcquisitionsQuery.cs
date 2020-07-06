using MicrosoftStoreServicesAPI.V1.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftStoreServices.V1.Acquisitions
{
    public class AcquisitionsQuery : OrderedQuery<AcquisitionsOrderBy>
    {
        public override string QueryName => "acquisitions";
        public AcquisitionsQuery()
        {

        }
    }
}
