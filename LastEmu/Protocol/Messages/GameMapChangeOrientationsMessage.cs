using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameMapChangeOrientationsMessage : NetworkMessage
	{
		public const uint Id = 6155;

		public ActorOrientation[] orientations;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6155;
			}
		}

		public GameMapChangeOrientationsMessage()
		{
		}

		public GameMapChangeOrientationsMessage(ActorOrientation[] orientations)
		{
			this.orientations = orientations;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.orientations = new ActorOrientation[num];
			for (int i = 0; i < num; i++)
			{
				this.orientations[i] = new ActorOrientation();
				this.orientations[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.orientations.Length));
			ActorOrientation[] actorOrientationArray = this.orientations;
			for (int i = 0; i < (int)actorOrientationArray.Length; i++)
			{
				actorOrientationArray[i].Serialize(writer);
			}
		}
	}
}