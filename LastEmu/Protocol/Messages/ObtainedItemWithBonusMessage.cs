using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ObtainedItemWithBonusMessage : ObtainedItemMessage
	{
		public const uint Id = 6520;

		public uint bonusQuantity;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6520;
			}
		}

		public ObtainedItemWithBonusMessage()
		{
		}

		public ObtainedItemWithBonusMessage(uint genericId, uint baseQuantity, uint bonusQuantity) : base(genericId, baseQuantity)
		{
			this.bonusQuantity = bonusQuantity;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.bonusQuantity = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.bonusQuantity);
		}
	}
}