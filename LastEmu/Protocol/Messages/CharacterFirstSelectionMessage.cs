using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class CharacterFirstSelectionMessage : CharacterSelectionMessage
	{
		public const uint Id = 6084;

		public bool doTutorial;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6084;
			}
		}

		public CharacterFirstSelectionMessage()
		{
		}

		public CharacterFirstSelectionMessage(double id, bool doTutorial) : base(id)
		{
			this.doTutorial = doTutorial;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.doTutorial = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(this.doTutorial);
		}
	}
}