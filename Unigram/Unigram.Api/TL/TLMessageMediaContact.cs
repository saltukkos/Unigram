// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessageMediaContact : TLMessageMediaBase 
	{
		public String PhoneNumber { get; set; }
		public String FirstName { get; set; }
		public String LastName { get; set; }
		public Int32 UserId { get; set; }

		public TLMessageMediaContact() { }
		public TLMessageMediaContact(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessageMediaContact; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			PhoneNumber = from.ReadString();
			FirstName = from.ReadString();
			LastName = from.ReadString();
			UserId = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x5E7D2F39);
			to.Write(PhoneNumber);
			to.Write(FirstName);
			to.Write(LastName);
			to.Write(UserId);
			if (cache) WriteToCache(to);
		}
	}
}