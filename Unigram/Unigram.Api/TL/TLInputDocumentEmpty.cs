// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputDocumentEmpty : TLInputDocumentBase 
	{
		public TLInputDocumentEmpty() { }
		public TLInputDocumentEmpty(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.InputDocumentEmpty; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x72F0EAAE);
			if (cache) WriteToCache(to);
		}
	}
}