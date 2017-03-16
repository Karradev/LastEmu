using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class InviteInHavenBagClosedMessage : NetworkMessage
	{
		public const uint Id = 6645;

		public CharacterMinimalInformations hostInformations;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6645;
			}
		}

		public InviteInHavenBagClosedMessage()
		{
		}

		public InviteInHavenBagClosedMessage(CharacterMinimalInformations hostInformations)
		{
			this.hostInformations = hostInformations;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.hostInformations = new CharacterMinimalInformations();
			this.hostInformations.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.hostInformations.Serialize(writer);
		}
	}
}