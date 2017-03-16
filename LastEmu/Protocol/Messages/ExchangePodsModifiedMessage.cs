using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ExchangePodsModifiedMessage : ExchangeObjectMessage
	{
		public const uint Id = 6670;

		public uint currentWeight;

		public uint maxWeight;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6670;
			}
		}

		public ExchangePodsModifiedMessage()
		{
		}

		public ExchangePodsModifiedMessage(bool remote, uint currentWeight, uint maxWeight) : base(remote)
		{
			this.currentWeight = currentWeight;
			this.maxWeight = maxWeight;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.currentWeight = reader.ReadVarUhInt();
			this.maxWeight = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.currentWeight);
			writer.WriteVarInt((int)this.maxWeight);
		}
	}
}