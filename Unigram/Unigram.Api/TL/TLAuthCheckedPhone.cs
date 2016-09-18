// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLAuthCheckedPhone : TLObject 
	{
		public Boolean PhoneRegistered { get; set; }

		public TLAuthCheckedPhone() { }
		public TLAuthCheckedPhone(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.AuthCheckedPhone; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			PhoneRegistered = from.ReadBoolean();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x811EA28E);
			to.Write(PhoneRegistered);
			if (cache) WriteToCache(to);
		}
	}
}