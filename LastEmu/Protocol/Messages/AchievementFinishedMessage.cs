using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AchievementFinishedMessage : NetworkMessage
	{
		public const uint Id = 6208;

		public uint id;

		public byte finishedlevel;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6208;
			}
		}

		public AchievementFinishedMessage()
		{
		}

		public AchievementFinishedMessage(uint id, byte finishedlevel)
		{
			this.id = id;
			this.finishedlevel = finishedlevel;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadVarUhShort();
			this.finishedlevel = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.id);
			writer.WriteByte(this.finishedlevel);
		}
	}
}