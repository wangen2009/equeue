﻿using System.Threading;
namespace EQueue.Remoting
{
    public class RemotingRequest
    {
        private static long _sequenceCounter;

        public int Code { get; private set; }
        public long Sequence { get; private set; }
        public byte[] Body { get; private set; }

        public RemotingRequest(int code, byte[] body)
        {
            Code = code;
            Sequence = Interlocked.Increment(ref _sequenceCounter);
            Body = body;
        }
    }
}
