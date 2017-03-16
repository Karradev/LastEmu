using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ExchangeObjectRemovedMessage : ExchangeObjectMessage
	{
		public const uint Id = 5517;

		public uint objectUID;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5517;
			}
		}

		public ExchangeObjectRemovedMessage()
		{
		}

		public ExchangeObjectRemovedMessage(bool remote, uint objectUID) : base(remote)
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