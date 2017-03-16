using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ServerSettingsMessage : NetworkMessage
	{
		public const uint Id = 6340;

		public string lang;

		public sbyte community;

		public sbyte gameType;

		public uint arenaLeaveBanTime;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6340;
			}
		}

		public ServerSettingsMessage()
		{
		}

		public ServerSettingsMessage(string lang, sbyte community, sbyte gameType, uint arenaLeaveBanTime)
		{
			this.lang = lang;
			this.community = community;
			this.gameType = gameType;
			this.arenaLeaveBanTime = arenaLeaveBanTime;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.lang = reader.ReadUTF();
			this.community = reader.ReadSByte();
			this.gameType = reader.ReadSByte();
			this.arenaLeaveBanTime = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.lang);
			writer.WriteSByte(this.community);
			writer.WriteSByte(this.gameType);
			writer.WriteVarShort((int)this.arenaLeaveBanTime);
		}
	}
}