// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.clearRecentStickers
	/// </summary>
	public partial class TLMessagesClearRecentStickers : TLObject
	{
		public TLMessagesClearRecentStickers() { }
		public TLMessagesClearRecentStickers(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessagesClearRecentStickers; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xAB02E5D2);
			if (cache) WriteToCache(to);
		}
	}
}