using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ArenaFighterLeaveMessage : NetworkMessage
	{
		public const uint Id = 6700;

		public CharacterBasicMinimalInformations leaver;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6700;
			}
		}

		public ArenaFighterLeaveMessage()
		{
		}

		public ArenaFighterLeaveMessage(CharacterBasicMinimalInformations leaver)
		{
			this.leaver = leaver;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.leaver = new CharacterBasicMinimalInformations();
			this.leaver.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.leaver.Serialize(writer);
		}
	}
}