using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ExchangeObjectRemovedFromBagMessage : ExchangeObjectMessage
	{
		public const uint Id = 6010;

		public uint objectUID;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6010;
			}
		}

		public ExchangeObjectRemovedFromBagMessage()
		{
		}

		public ExchangeObjectRemovedFromBagMessage(bool remote, uint objectUID) : base(remote)
		{
			this.objectUID = objectUID;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.objectUID = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.objectUID);
		}
	}
}