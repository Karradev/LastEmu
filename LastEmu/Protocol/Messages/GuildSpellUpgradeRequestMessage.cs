using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildSpellUpgradeRequestMessage : NetworkMessage
	{
		public const uint Id = 5699;

		public int spellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5699;
			}
		}

		public GuildSpellUpgradeRequestMessage()
		{
		}

		public GuildSpellUpgradeRequestMessage(int spellId)
		{
			this.spellId = spellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.spellId = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.spellId);
		}
	}
}