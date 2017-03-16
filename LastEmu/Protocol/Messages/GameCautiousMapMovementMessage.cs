using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameCautiousMapMovementMessage : GameMapMovementMessage
	{
		public const uint Id = 6497;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6497;
			}
		}

		public GameCautiousMapMovementMessage()
		{
		}

		public GameCautiousMapMovementMessage(short[] keyMovements, double actorId) : base(keyMovements, actorId)
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