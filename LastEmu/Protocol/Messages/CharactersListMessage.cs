using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class CharactersListMessage : BasicCharactersListMessage
	{
		public const uint Id = 151;

		public bool hasStartupActions;

		public override uint ProtocolId
		{
			get
			{
				return (uint)151;
			}
		}

		public CharactersListMessage()
		{
		}

		public CharactersListMessage(CharacterBaseInformations[] characters, bool hasStartupActions) : base(characters)
		{
			this.hasStartupActions = hasStartupActions;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.hasStartupActions = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(this.hasStartupActions);
		}
	}
}