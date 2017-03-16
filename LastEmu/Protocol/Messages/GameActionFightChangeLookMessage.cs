using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameActionFightChangeLookMessage : AbstractGameActionMessage
	{
		public const uint Id = 5532;

		public double targetId;

		public EntityLook entityLook;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5532;
			}
		}

		public GameActionFightChangeLookMessage()
		{
		}

		public GameActionFightChangeLookMessage(uint actionId, double sourceId, double targetId, EntityLook entityLook) : base(actionId, sourceId)
		{
			this.targetId = targetId;
			this.entityLook = entityLook;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.targetId = reader.ReadDouble();
			this.entityLook = new EntityLook();
			this.entityLook.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.targetId);
			this.entityLook.Serialize(writer);
		}
	}
}