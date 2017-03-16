using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GuildFightTakePlaceRequestMessage : GuildFightJoinRequestMessage
	{
		public const uint Id = 6235;

		public int replacedCharacterId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6235;
			}
		}

		public GuildFightTakePlaceRequestMessage()
		{
		}

		public GuildFightTakePlaceRequestMessage(int taxCollectorId, int replacedCharacterId) : base(taxCollectorId)
		{
			this.replacedCharacterId = replacedCharacterId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.replacedCharacterId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.replacedCharacterId);
		}
	}
}