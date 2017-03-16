using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameFightPlacementSwapPositionsRequestMessage : GameFightPlacementPositionRequestMessage
	{
		public const uint Id = 6541;

		public double requestedId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6541;
			}
		}

		public GameFightPlacementSwapPositionsRequestMessage()
		{
		}

		public GameFightPlacementSwapPositionsRequestMessage(uint cellId, double requestedId) : base(cellId)
		{
			this.requestedId = requestedId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.requestedId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.requestedId);
		}
	}
}