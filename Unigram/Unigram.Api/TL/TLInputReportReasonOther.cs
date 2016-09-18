// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputReportReasonOther : TLReportReasonBase 
	{
		public String Text { get; set; }

		public TLInputReportReasonOther() { }
		public TLInputReportReasonOther(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.InputReportReasonOther; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Text = from.ReadString();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xE1746D0A);
			to.Write(Text);
			if (cache) WriteToCache(to);
		}
	}
}