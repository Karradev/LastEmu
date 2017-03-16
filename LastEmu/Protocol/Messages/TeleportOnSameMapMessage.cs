using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TeleportOnSameMapMessage : NetworkMessage
	{
		public const uint Id = 6048;

		public double targetId;

		public uint cellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6048;
			}
		}

		public TeleportOnSameMapMessage()
		{
		}

		public TeleportOnSameMapMessage(double targetId, uint cellId)
		{
			this.targetId = targetId;
			this.cellId = cellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.targetId = reader.ReadDouble();
			this.cellId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.targetId);
			writer.WriteVarShort((int)this.cellId);
		}
	}
}