using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharacterCapabilitiesMessage : NetworkMessage
	{
		public const uint Id = 6339;

		public uint guildEmblemSymbolCategories;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6339;
			}
		}

		public CharacterCapabilitiesMessage()
		{
		}

		public CharacterCapabilitiesMessage(uint guildEmblemSymbolCategories)
		{
			this.guildEmblemSymbolCategories = guildEmblemSymbolCategories;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.guildEmblemSymbolCategories = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.guildEmblemSymbolCategories);
		}
	}
}