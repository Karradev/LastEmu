using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class CharacterLevelUpInformationMessage : CharacterLevelUpMessage
	{
		public const uint Id = 6076;

		public string name;

		public double id;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6076;
			}
		}

		public CharacterLevelUpInformationMessage()
		{
		}

		public CharacterLevelUpInformationMessage(byte newLevel, string name, double id) : base(newLevel)
		{
			this.name = name;
			this.id = id;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.name = reader.ReadUTF();
			this.id = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.name);
			writer.WriteVarLong(this.id);
		}
	}
}