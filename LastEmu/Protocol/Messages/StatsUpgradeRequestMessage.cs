using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class StatsUpgradeRequestMessage : NetworkMessage
	{
		public const uint Id = 5610;

		public bool useAdditionnal;

		public sbyte statId;

		public uint boostPoint;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5610;
			}
		}

		public StatsUpgradeRequestMessage()
		{
		}

		public StatsUpgradeRequestMessage(bool useAdditionnal, sbyte statId, uint boostPoint)
		{
			this.useAdditionnal = useAdditionnal;
			this.statId = statId;
			this.boostPoint = boostPoint;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.useAdditionnal = reader.ReadBoolean();
			this.statId = reader.ReadSByte();
			this.boostPoint = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.useAdditionnal);
			writer.WriteSByte(this.statId);
			writer.WriteVarShort((int)this.boostPoint);
		}
	}
}