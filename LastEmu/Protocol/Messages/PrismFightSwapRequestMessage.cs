using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PrismFightSwapRequestMessage : NetworkMessage
	{
		public const uint Id = 5901;

		public uint subAreaId;

		public double targetId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5901;
			}
		}

		public PrismFightSwapRequestMessage()
		{
		}

		public PrismFightSwapRequestMessage(uint subAreaId, double targetId)
		{
			this.subAreaId = subAreaId;
			this.targetId = targetId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.subAreaId = reader.ReadVarUhShort();
			this.targetId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.subAreaId);
			writer.WriteVarLong(this.targetId);
		}
	}
}