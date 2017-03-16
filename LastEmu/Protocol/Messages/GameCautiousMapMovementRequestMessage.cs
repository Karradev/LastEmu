using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameCautiousMapMovementRequestMessage : GameMapMovementRequestMessage
	{
		public const uint Id = 6496;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6496;
			}
		}

		public GameCautiousMapMovementRequestMessage()
		{
		}

		public GameCautiousMapMovementRequestMessage(short[] keyMovements, int mapId) : base(keyMovements, mapId)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}