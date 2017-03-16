using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class InteractiveUsedMessage : NetworkMessage
	{
		public const uint Id = 5745;

		public double entityId;

		public uint elemId;

		public uint skillId;

		public uint duration;

		public bool canMove;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5745;
			}
		}

		public InteractiveUsedMessage()
		{
		}

		public InteractiveUsedMessage(double entityId, uint elemId, uint skillId, uint duration, bool canMove)
		{
			this.entityId = entityId;
			this.elemId = elemId;
			this.skillId = skillId;
			this.duration = duration;
			this.canMove = canMove;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.entityId = reader.ReadVarUhLong();
			this.elemId = reader.ReadVarUhInt();
			this.skillId = reader.ReadVarUhShort();
			this.duration = reader.ReadVarUhShort();
			this.canMove = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.entityId);
			writer.WriteVarInt((int)this.elemId);
			writer.WriteVarShort((int)this.skillId);
			writer.WriteVarShort((int)this.duration);
			writer.WriteBoolean(this.canMove);
		}
	}
}