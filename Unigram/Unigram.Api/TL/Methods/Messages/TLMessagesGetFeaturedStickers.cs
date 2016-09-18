// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getFeaturedStickers
	/// </summary>
	public partial class TLMessagesGetFeaturedStickers : TLObject
	{
		public Int32 Hash { get; set; }

		public TLMessagesGetFeaturedStickers() { }
		public TLMessagesGetFeaturedStickers(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessagesGetFeaturedStickers; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Hash = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x2DACCA4F);
			to.Write(Hash);
			if (cache) WriteToCache(to);
		}
	}
}