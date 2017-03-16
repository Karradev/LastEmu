using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightRemoveTeamMemberMessage : NetworkMessage
	{
		public const uint Id = 711;

		public short fightId;

		public sbyte teamId;

		public double charId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)711;
			}
		}

		public GameFightRemoveTeamMemberMessage()
		{
		}

		public GameFightRemoveTeamMemberMessage(short fightId, sbyte teamId, double charId)
		{
			this.fightId = fightId;
			this.teamId = teamId;
			this.charId = charId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fightId = reader.ReadShort();
			this.teamId = reader.ReadSByte();
			this.charId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.fightId);
			writer.WriteSByte(this.teamId);
			writer.WriteDouble(this.charId);
		}
	}
}