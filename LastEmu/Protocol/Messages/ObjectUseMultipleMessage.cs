using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ObjectUseMultipleMessage : ObjectUseMessage
	{
		public const uint Id = 6234;

		public uint quantity;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6234;
			}
		}

		public ObjectUseMultipleMessage()
		{
		}

		public ObjectUseMultipleMessage(uint objectUID, uint quantity) : base(objectUID)
		{
			this.quantity = quantity;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.quantity = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.quantity);
		}
	}
}