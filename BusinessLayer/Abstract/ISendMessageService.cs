﻿using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISendMessageService : IGenericService<SendMessage>
    {
        public int TGetSendMessageCount();
    }
}
