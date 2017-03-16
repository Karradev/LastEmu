using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameRolePlayShowActorWithEventMessage : GameRolePlayShowActorMessage
	{
		public const uint Id = 6407;

		public sbyte actorEventId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6407;
			}
		}

		public GameRolePlayShowActorWithEventMessage()
		{
		}

		public GameRolePlayShowActorWithEventMessage(GameRolePlayActorInformations informations, sbyte actorEventId) : base(informations)
		{
			this.actorEventId = actorEventId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.actorEventId = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.actorEventId);
		}
	}
}