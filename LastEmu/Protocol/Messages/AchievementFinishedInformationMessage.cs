using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class AchievementFinishedInformationMessage : AchievementFinishedMessage
	{
		public const uint Id = 6381;

		public string name;

		public double playerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6381;
			}
		}

		public AchievementFinishedInformationMessage()
		{
		}

		public AchievementFinishedInformationMessage(uint id, byte finishedlevel, string name, double playerId) : base(id, finishedlevel)
		{
			this.name = name;
			this.playerId = playerId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.name = reader.ReadUTF();
			this.playerId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.name);
			writer.WriteVarLong(this.playerId);
		}
	}
}