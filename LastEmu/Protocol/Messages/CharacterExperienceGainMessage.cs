using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CharacterExperienceGainMessage : NetworkMessage
	{
		public const uint Id = 6321;

		public double experienceCharacter;

		public double experienceMount;

		public double experienceGuild;

		public double experienceIncarnation;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6321;
			}
		}

		public CharacterExperienceGainMessage()
		{
		}

		public CharacterExperienceGainMessage(double experienceCharacter, double experienceMount, double experienceGuild, double experienceIncarnation)
		{
			this.experienceCharacter = experienceCharacter;
			this.experienceMount = experienceMount;
			this.experienceGuild = experienceGuild;
			this.experienceIncarnation = experienceIncarnation;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.experienceCharacter = reader.ReadVarUhLong();
			this.experienceMount = reader.ReadVarUhLong();
			this.experienceGuild = reader.ReadVarUhLong();
			this.experienceIncarnation = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.experienceCharacter);
			writer.WriteVarLong(this.experienceMount);
			writer.WriteVarLong(this.experienceGuild);
			writer.WriteVarLong(this.experienceIncarnation);
		}
	}
}