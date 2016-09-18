// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods
{
	/// <summary>
	/// RCP method rpc_drop_answer
	/// </summary>
	public partial class TLRPCDropAnswer : TLObject
	{
		public Int64 ReqMsgId { get; set; }

		public TLRPCDropAnswer() { }
		public TLRPCDropAnswer(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.RPCDropAnswer; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			ReqMsgId = from.ReadInt64();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x58E4A740);
			to.Write(ReqMsgId);
			if (cache) WriteToCache(to);
		}
	}
}