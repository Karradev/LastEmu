using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameMapMovementCancelMessage : NetworkMessage
	{
		public const uint Id = 953;

		public uint cellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)953;
			}
		}

		public GameMapMovementCancelMessage()
		{
		}

		public GameMapMovementCancelMessage(uint cellId)
		{
			this.cellId = cellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.cellId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.cellId);
		}
	}
}