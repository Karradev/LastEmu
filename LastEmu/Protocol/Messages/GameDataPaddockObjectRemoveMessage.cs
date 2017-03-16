using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameDataPaddockObjectRemoveMessage : NetworkMessage
	{
		public const uint Id = 5993;

		public uint cellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5993;
			}
		}

		public GameDataPaddockObjectRemoveMessage()
		{
		}

		public GameDataPaddockObjectRemoveMessage(uint cellId)
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