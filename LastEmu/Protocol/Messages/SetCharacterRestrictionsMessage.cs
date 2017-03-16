using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class SetCharacterRestrictionsMessage : NetworkMessage
	{
		public const uint Id = 170;

		public double actorId;

		public ActorRestrictionsInformations restrictions;

		public override uint ProtocolId
		{
			get
			{
				return (uint)170;
			}
		}

		public SetCharacterRestrictionsMessage()
		{
		}

		public SetCharacterRestrictionsMessage(double actorId, ActorRestrictionsInformations restrictions)
		{
			this.actorId = actorId;
			this.restrictions = restrictions;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.actorId = reader.ReadDouble();
			this.restrictions = new ActorRestrictionsInformations();
			this.restrictions.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.actorId);
			this.restrictions.Serialize(writer);
		}
	}
}