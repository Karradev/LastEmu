using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightPlacementSwapPositionsOfferMessage : NetworkMessage
	{
		public const uint Id = 6542;

		public int requestId;

		public double requesterId;

		public uint requesterCellId;

		public double requestedId;

		public uint requestedCellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6542;
			}
		}

		public GameFightPlacementSwapPositionsOfferMessage()
		{
		}

		public GameFightPlacementSwapPositionsOfferMessage(int requestId, double requesterId, uint requesterCellId, double requestedId, uint requestedCellId)
		{
			this.requestId = requestId;
			this.requesterId = requesterId;
			this.requesterCellId = requesterCellId;
			this.requestedId = requestedId;
			this.requestedCellId = requestedCellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.requestId = reader.ReadInt();
			this.requesterId = reader.ReadDouble();
			this.requesterCellId = reader.ReadVarUhShort();
			this.requestedId = reader.ReadDouble();
			this.requestedCellId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.requestId);
			writer.WriteDouble(this.requesterId);
			writer.WriteVarShort((int)this.requesterCellId);
			writer.WriteDouble(this.requestedId);
			writer.WriteVarShort((int)this.requestedCellId);
		}
	}
}