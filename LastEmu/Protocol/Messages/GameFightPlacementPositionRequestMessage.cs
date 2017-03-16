using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightPlacementPositionRequestMessage : NetworkMessage
	{
		public const uint Id = 704;

		public uint cellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)704;
			}
		}

		public GameFightPlacementPositionRequestMessage()
		{
		}

		public GameFightPlacementPositionRequestMessage(uint cellId)
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