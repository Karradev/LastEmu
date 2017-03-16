using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameMapChangeOrientationMessage : NetworkMessage
	{
		public const uint Id = 946;

		public ActorOrientation orientation;

		public override uint ProtocolId
		{
			get
			{
				return (uint)946;
			}
		}

		public GameMapChangeOrientationMessage()
		{
		}

		public GameMapChangeOrientationMessage(ActorOrientation orientation)
		{
			this.orientation = orientation;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.orientation = new ActorOrientation();
			this.orientation.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.orientation.Serialize(writer);
		}
	}
}