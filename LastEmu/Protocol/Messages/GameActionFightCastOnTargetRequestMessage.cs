using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameActionFightCastOnTargetRequestMessage : NetworkMessage
	{
		public const uint Id = 6330;

		public uint spellId;

		public double targetId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6330;
			}
		}

		public GameActionFightCastOnTargetRequestMessage()
		{
		}

		public GameActionFightCastOnTargetRequestMessage(uint spellId, double targetId)
		{
			this.spellId = spellId;
			this.targetId = targetId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.spellId = reader.ReadVarUhShort();
			this.targetId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.spellId);
			writer.WriteDouble(this.targetId);
		}
	}
}